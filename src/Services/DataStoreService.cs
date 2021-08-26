// <copyright file="JsonDataStoreService.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace subscription_manual_tester.Services
{
    /// <summary>A service for accessing data stores information.</summary>
    public class DataStoreService : IHostedService, IDisposable
    {
        /// <summary>REST endpoint.</summary>
        /// <param name="RestUri">The REST URI for this endpoint.</param>
        /// <param name="Headers">Headers to include in requests to the endpoint.</param>
        /// <returns>A record.</returns>
        public record RestEndpoint(Uri RestUri, List<string> Headers);

        /// <summary>Flag to track if we have disposed internal resources (IDisposable dispose pattern).</summary>
        private bool _disposedValue;

        /// <summary>The data store dir.</summary>
        private string _dataStoreDir;

        /// <summary>The endpoint dir.</summary>
        private string _endpointDir;

        /// <summary>The resource dir.</summary>
        private string _resourceDir;

        /// <summary>Dictionary of endpoints.</summary>
        private Dictionary<Uri, RestEndpoint> _restEndpointDict;

        private Dictionary<string, Dictionary<string, fhirCsR4.Models.Resource>> _resourceByTypeById;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataStoreService"/> class.
        /// </summary>
        public DataStoreService()
        {
            _restEndpointDict = new Dictionary<Uri, RestEndpoint>();
            _resourceByTypeById = new Dictionary<string, Dictionary<string, fhirCsR4.Models.Resource>>();
        }

        /// <summary>The REST endpoints.</summary>
        public Dictionary<Uri, RestEndpoint> RestEndpoints { get => _restEndpointDict; set => _restEndpointDict = value; }

        public Dictionary<string, Dictionary<string, fhirCsR4.Models.Resource>> Resources 
        { 
            get => _resourceByTypeById;
            set => _resourceByTypeById = value;
        }

        /// <summary>Triggered when the application host is ready to start the service.</summary>
        /// <param name="cancellationToken">Indicates that the start process has been aborted.</param>
        /// <returns>An asynchronous result.</returns>
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("DataStoreService <<< Starting...");

            InitDataStore();

            return Task.CompletedTask;
        }

        /// <summary>Triggered when the application host is performing a graceful shutdown.</summary>
        /// <param name="cancellationToken">Indicates that the shutdown process should no longer be
        ///  graceful.</param>
        /// <returns>An asynchronous result.</returns>
        public Task StopAsync(CancellationToken cancellationToken)
        {
            Save();

            return Task.CompletedTask;
        }

        /// <summary>Initializes the data store.</summary>
        private void InitDataStore()
        {
            try
            {
                _dataStoreDir = Path.Combine(Path.GetDirectoryName(AppContext.BaseDirectory), "data");
                if (!Directory.Exists(_dataStoreDir))
                {
                    Directory.CreateDirectory(_dataStoreDir);
                }

                _endpointDir = Path.Combine(_dataStoreDir, "endpoints");
                if (!Directory.Exists(_endpointDir))
                {
                    Directory.CreateDirectory(_endpointDir);
                }

                _resourceDir = Path.Combine(_dataStoreDir, "resources");
                if (!Directory.Exists(_resourceDir))
                {
                    Directory.CreateDirectory(_resourceDir);
                }

                LoadRestEndpoints();
                LoadFhirData();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to initialize the data store: {ex.Message}");
            }
        }

        private void LoadFhirData()
        {
            string[] files = Directory.GetFiles(_resourceDir, "*.json", SearchOption.TopDirectoryOnly);

            foreach (string filename in files)
            {
                string shortName = Path.GetFileNameWithoutExtension(filename);

                string contents = File.ReadAllText(filename);

                _resourceByTypeById.Add(
                    shortName,
                    JsonSerializer.Deserialize<Dictionary<string, fhirCsR4.Models.Resource>>(contents));
            }
        }

        /// <summary>Loads REST endpoints.</summary>
        private void LoadRestEndpoints()
        {
            string filename = Path.Combine(_endpointDir, "rest.json");

            if (!File.Exists(filename))
            {
                return;
            }

            string data = File.ReadAllText(filename);

            List<RestEndpoint> endpoints = JsonSerializer.Deserialize<List<RestEndpoint>>(data);

            _restEndpointDict = new Dictionary<Uri, RestEndpoint>();
            foreach (RestEndpoint endpoint in endpoints)
            {
                _restEndpointDict.Add(endpoint.RestUri, endpoint);
            }
        }

        /// <summary>Saves current data.</summary>
        public void Save()
        {
            try
            {
                SaveRestEndpoints();
                SaveFhirData();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to save data: {ex.Message}");
            }
        }

        /// <summary>Saves the asynchronous.</summary>
        public void SaveAsync()
        {
            Task.Run(() => Save());
        }

        private void SaveFhirData()
        {
            HashSet<string> savedResources = new HashSet<string>();
            string[] files = Directory.GetFiles(_resourceDir, "*.json", SearchOption.TopDirectoryOnly);

            foreach (string filename in files)
            {
                string shortName = Path.GetFileNameWithoutExtension(filename);

                if (_resourceByTypeById.ContainsKey(shortName))
                {
                    File.WriteAllText(
                        filename,
                        JsonSerializer.Serialize(_resourceByTypeById[shortName]));

                    savedResources.Add(shortName);

                    continue;
                }

                File.Delete(filename);
            }

            foreach (KeyValuePair<string, Dictionary<string, fhirCsR4.Models.Resource>> kvp in _resourceByTypeById)
            {
                if (savedResources.Contains(kvp.Key))
                {
                    continue;
                }

                File.WriteAllText(
                    Path.Combine(_resourceDir, kvp.Key + ".json"),
                    JsonSerializer.Serialize(kvp.Value));

                savedResources.Add(kvp.Key);
            }
        }


        /// <summary>Saves the REST endpoints.</summary>
        private void SaveRestEndpoints()
        {
            string filename = Path.Combine(_endpointDir, "rest.json");

            string data = JsonSerializer.Serialize(_restEndpointDict.Values);

            File.WriteAllText(filename, data);
        }

        /// <summary>
        /// Releases the unmanaged resources used by the
        /// subscription_manual_tester.Services.JsonDataStoreService and optionally releases the managed
        /// resources.
        /// </summary>
        /// <param name="disposing">True to release both managed and unmanaged resources; false to
        ///  release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~JsonDataStoreService()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
