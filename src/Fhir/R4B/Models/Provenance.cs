// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR4.Serialization;

namespace fhirCsR4.Models
{
  /// <summary>
  /// Several agents may be associated (i.e. has some responsibility for an activity) with an activity and vice-versa.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<ProvenanceAgent>))]
  public class ProvenanceAgent : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// onBehalfOfIdentity should be used when the agent is not a Resource type.
    /// </summary>
    public Reference OnBehalfOf { get; set; }
    /// <summary>
    /// For example: doctor, nurse, clerk, etc.
    /// </summary>
    public List<CodeableConcept> Role { get; set; }
    /// <summary>
    /// For example: author, performer, enterer, attester, etc.
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// whoIdentity should be used when the agent is not a Resource type.
    /// </summary>
    public Reference Who { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if ((Role != null) && (Role.Count != 0))
      {
        writer.WritePropertyName("role");
        writer.WriteStartArray();

        foreach (CodeableConcept valRole in Role)
        {
          valRole.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Who != null)
      {
        writer.WritePropertyName("who");
        Who.SerializeJson(writer, options);
      }

      if (OnBehalfOf != null)
      {
        writer.WritePropertyName("onBehalfOf");
        OnBehalfOf.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "onBehalfOf":
          OnBehalfOf = new fhirCsR4.Models.Reference();
          OnBehalfOf.DeserializeJson(ref reader, options);
          break;

        case "role":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Role = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.CodeableConcept objRole = new fhirCsR4.Models.CodeableConcept();
            objRole.DeserializeJson(ref reader, options);
            Role.Add(objRole);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Role.Count == 0)
          {
            Role = null;
          }

          break;

        case "type":
          Type = new fhirCsR4.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        case "who":
          Who = new fhirCsR4.Models.Reference();
          Who.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// An entity used in this activity.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<ProvenanceEntity>))]
  public class ProvenanceEntity : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A usecase where one Provenance.entity.agent is used where the Entity that was used in the creation/updating of the Target, is not in the context of the same custodianship as the Target, and thus the meaning of Provenance.entity.agent is to say that the entity referenced is managed elsewhere and that this Agent provided access to it.  This would be similar to where the Entity being referenced is managed outside FHIR, such as through HL7 v2, v3, or XDS. This might be where the Entity being referenced is managed in another FHIR resource server. Thus it explains the Provenance of that Entity's use in the context of this Provenance activity.
    /// </summary>
    public List<ProvenanceAgent> Agent { get; set; }
    /// <summary>
    /// How the entity was used during the activity.
    /// </summary>
    public string Role { get; set; }
    /// <summary>
    /// Extension container element for Role
    /// </summary>
    public Element _Role { get; set; }
    /// <summary>
    /// whatIdentity should be used for entities that are not a Resource type.
    /// </summary>
    public Reference What { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Role))
      {
        writer.WriteString("role", (string)Role!);
      }

      if (_Role != null)
      {
        writer.WritePropertyName("_role");
        _Role.SerializeJson(writer, options);
      }

      if (What != null)
      {
        writer.WritePropertyName("what");
        What.SerializeJson(writer, options);
      }

      if ((Agent != null) && (Agent.Count != 0))
      {
        writer.WritePropertyName("agent");
        writer.WriteStartArray();

        foreach (ProvenanceAgent valAgent in Agent)
        {
          valAgent.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "agent":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Agent = new List<ProvenanceAgent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.ProvenanceAgent objAgent = new fhirCsR4.Models.ProvenanceAgent();
            objAgent.DeserializeJson(ref reader, options);
            Agent.Add(objAgent);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Agent.Count == 0)
          {
            Agent = null;
          }

          break;

        case "role":
          Role = reader.GetString();
          break;

        case "_role":
          _Role = new fhirCsR4.Models.Element();
          _Role.DeserializeJson(ref reader, options);
          break;

        case "what":
          What = new fhirCsR4.Models.Reference();
          What.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Code Values for the Provenance.entity.role field
  /// </summary>
  public static class ProvenanceEntityRoleCodes {
    public const string DERIVATION = "derivation";
    public const string REVISION = "revision";
    public const string QUOTATION = "quotation";
    public const string SOURCE = "source";
    public const string REMOVAL = "removal";
  }
  /// <summary>
  /// Provenance of a resource is a record that describes entities and processes involved in producing and delivering or otherwise influencing that resource. Provenance provides a critical foundation for assessing authenticity, enabling trust, and allowing reproducibility. Provenance assertions are a form of contextual metadata and can themselves become important records with their own provenance. Provenance statement indicates clinical significance in terms of confidence in authenticity, reliability, and trustworthiness, integrity, and stage in lifecycle (e.g. Document Completion - has the artifact been legally authenticated), all of which may impact security, privacy, and trust policies.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<Provenance>))]
  public class Provenance : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Provenance";
    /// <summary>
    /// An activity is something that occurs over a period of time and acts upon or with entities; it may include consuming, processing, transforming, modifying, relocating, using, or generating entities.
    /// </summary>
    public CodeableConcept Activity { get; set; }
    /// <summary>
    /// Several agents may be associated (i.e. has some responsibility for an activity) with an activity and vice-versa.
    /// </summary>
    public List<ProvenanceAgent> Agent { get; set; }
    /// <summary>
    /// An entity used in this activity.
    /// </summary>
    public List<ProvenanceEntity> Entity { get; set; }
    /// <summary>
    /// Where the activity occurred, if relevant.
    /// </summary>
    public Reference Location { get; set; }
    /// <summary>
    /// The period can be a little arbitrary; where possible, the time should correspond to human assessment of the activity time.
    /// </summary>
    public Period OccurredPeriod { get; set; }
    /// <summary>
    /// The period can be a little arbitrary; where possible, the time should correspond to human assessment of the activity time.
    /// </summary>
    public string OccurredDateTime { get; set; }
    /// <summary>
    /// Extension container element for OccurredDateTime
    /// </summary>
    public Element _OccurredDateTime { get; set; }
    /// <summary>
    /// For example: Where an OAuth token authorizes, the unique identifier from the OAuth token is placed into the policy element Where a policy engine (e.g. XACML) holds policy logic, the unique policy identifier is placed into the policy element.
    /// </summary>
    public List<string> Policy { get; set; }
    /// <summary>
    /// Extension container element for Policy
    /// </summary>
    public List<Element> _Policy { get; set; }
    /// <summary>
    /// The reason that the activity was taking place.
    /// </summary>
    public List<CodeableConcept> Reason { get; set; }
    /// <summary>
    /// This can be a little different from the time stamp on the resource if there is a delay between recording the event and updating the provenance and target resource.
    /// </summary>
    public string Recorded { get; set; }
    /// <summary>
    /// Extension container element for Recorded
    /// </summary>
    public Element _Recorded { get; set; }
    /// <summary>
    /// A digital signature on the target Reference(s). The signer should match a Provenance.agent. The purpose of the signature is indicated.
    /// </summary>
    public List<Signature> Signature { get; set; }
    /// <summary>
    /// Target references are usually version specific, but might not be, if a version has not been assigned or if the provenance information is part of the set of resources being maintained (i.e. a document). When using the RESTful API, the identity of the resource might not be known (especially not the version specific one); the client may either submit the resource first, and then the provenance, or it may submit both using a single transaction. See the notes on transaction for further discussion.
    /// </summary>
    public List<Reference> Target { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((fhirCsR4.Models.DomainResource)this).SerializeJson(writer, options, false);

      if ((Target != null) && (Target.Count != 0))
      {
        writer.WritePropertyName("target");
        writer.WriteStartArray();

        foreach (Reference valTarget in Target)
        {
          valTarget.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (OccurredPeriod != null)
      {
        writer.WritePropertyName("occurredPeriod");
        OccurredPeriod.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(OccurredDateTime))
      {
        writer.WriteString("occurredDateTime", (string)OccurredDateTime!);
      }

      if (_OccurredDateTime != null)
      {
        writer.WritePropertyName("_occurredDateTime");
        _OccurredDateTime.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Recorded))
      {
        writer.WriteString("recorded", (string)Recorded!);
      }

      if (_Recorded != null)
      {
        writer.WritePropertyName("_recorded");
        _Recorded.SerializeJson(writer, options);
      }

      if ((Policy != null) && (Policy.Count != 0))
      {
        writer.WritePropertyName("policy");
        writer.WriteStartArray();

        foreach (string valPolicy in Policy)
        {
          writer.WriteStringValue(valPolicy);
        }

        writer.WriteEndArray();
      }

      if ((_Policy != null) && (_Policy.Count != 0))
      {
        writer.WritePropertyName("_policy");
        writer.WriteStartArray();

        foreach (Element val_Policy in _Policy)
        {
          val_Policy.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Location != null)
      {
        writer.WritePropertyName("location");
        Location.SerializeJson(writer, options);
      }

      if ((Reason != null) && (Reason.Count != 0))
      {
        writer.WritePropertyName("reason");
        writer.WriteStartArray();

        foreach (CodeableConcept valReason in Reason)
        {
          valReason.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Activity != null)
      {
        writer.WritePropertyName("activity");
        Activity.SerializeJson(writer, options);
      }

      if ((Agent != null) && (Agent.Count != 0))
      {
        writer.WritePropertyName("agent");
        writer.WriteStartArray();

        foreach (ProvenanceAgent valAgent in Agent)
        {
          valAgent.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Entity != null) && (Entity.Count != 0))
      {
        writer.WritePropertyName("entity");
        writer.WriteStartArray();

        foreach (ProvenanceEntity valEntity in Entity)
        {
          valEntity.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Signature != null) && (Signature.Count != 0))
      {
        writer.WritePropertyName("signature");
        writer.WriteStartArray();

        foreach (Signature valSignature in Signature)
        {
          valSignature.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "activity":
          Activity = new fhirCsR4.Models.CodeableConcept();
          Activity.DeserializeJson(ref reader, options);
          break;

        case "agent":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Agent = new List<ProvenanceAgent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.ProvenanceAgent objAgent = new fhirCsR4.Models.ProvenanceAgent();
            objAgent.DeserializeJson(ref reader, options);
            Agent.Add(objAgent);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Agent.Count == 0)
          {
            Agent = null;
          }

          break;

        case "entity":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Entity = new List<ProvenanceEntity>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.ProvenanceEntity objEntity = new fhirCsR4.Models.ProvenanceEntity();
            objEntity.DeserializeJson(ref reader, options);
            Entity.Add(objEntity);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Entity.Count == 0)
          {
            Entity = null;
          }

          break;

        case "location":
          Location = new fhirCsR4.Models.Reference();
          Location.DeserializeJson(ref reader, options);
          break;

        case "occurredPeriod":
          OccurredPeriod = new fhirCsR4.Models.Period();
          OccurredPeriod.DeserializeJson(ref reader, options);
          break;

        case "occurredDateTime":
          OccurredDateTime = reader.GetString();
          break;

        case "_occurredDateTime":
          _OccurredDateTime = new fhirCsR4.Models.Element();
          _OccurredDateTime.DeserializeJson(ref reader, options);
          break;

        case "policy":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Policy = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Policy.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Policy.Count == 0)
          {
            Policy = null;
          }

          break;

        case "_policy":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Policy = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Element obj_Policy = new fhirCsR4.Models.Element();
            obj_Policy.DeserializeJson(ref reader, options);
            _Policy.Add(obj_Policy);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Policy.Count == 0)
          {
            _Policy = null;
          }

          break;

        case "reason":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Reason = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.CodeableConcept objReason = new fhirCsR4.Models.CodeableConcept();
            objReason.DeserializeJson(ref reader, options);
            Reason.Add(objReason);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Reason.Count == 0)
          {
            Reason = null;
          }

          break;

        case "recorded":
          Recorded = reader.GetString();
          break;

        case "_recorded":
          _Recorded = new fhirCsR4.Models.Element();
          _Recorded.DeserializeJson(ref reader, options);
          break;

        case "signature":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Signature = new List<Signature>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Signature objSignature = new fhirCsR4.Models.Signature();
            objSignature.DeserializeJson(ref reader, options);
            Signature.Add(objSignature);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Signature.Count == 0)
          {
            Signature = null;
          }

          break;

        case "target":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Target = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Reference objTarget = new fhirCsR4.Models.Reference();
            objTarget.DeserializeJson(ref reader, options);
            Target.Add(objTarget);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Target.Count == 0)
          {
            Target = null;
          }

          break;

        default:
          ((fhirCsR4.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
}
