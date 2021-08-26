// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Describes the category of the metric.
  /// </summary>
  public static class MetricCategoryCodes
  {
    /// <summary>
    /// DeviceObservations generated for this DeviceMetric are calculated.
    /// </summary>
    public static readonly Coding Calculation = new Coding
    {
      Code = "calculation",
      Display = "Calculation",
      System = "http://hl7.org/fhir/metric-category"
    };
    /// <summary>
    /// DeviceObservations generated for this DeviceMetric are measured.
    /// </summary>
    public static readonly Coding Measurement = new Coding
    {
      Code = "measurement",
      Display = "Measurement",
      System = "http://hl7.org/fhir/metric-category"
    };
    /// <summary>
    /// DeviceObservations generated for this DeviceMetric is a setting that will influence the behavior of the Device.
    /// </summary>
    public static readonly Coding Setting = new Coding
    {
      Code = "setting",
      Display = "Setting",
      System = "http://hl7.org/fhir/metric-category"
    };
    /// <summary>
    /// The category of this DeviceMetric is unspecified.
    /// </summary>
    public static readonly Coding Unspecified = new Coding
    {
      Code = "unspecified",
      Display = "Unspecified",
      System = "http://hl7.org/fhir/metric-category"
    };

    /// <summary>
    /// Literal for code: Calculation
    /// </summary>
    public const string LiteralCalculation = "calculation";

    /// <summary>
    /// Literal for code: Measurement
    /// </summary>
    public const string LiteralMeasurement = "measurement";

    /// <summary>
    /// Literal for code: Setting
    /// </summary>
    public const string LiteralSetting = "setting";

    /// <summary>
    /// Literal for code: Unspecified
    /// </summary>
    public const string LiteralUnspecified = "unspecified";
  };
}
