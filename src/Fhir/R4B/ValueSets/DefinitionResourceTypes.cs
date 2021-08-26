// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// A list of all the definition resource types defined in this version of the FHIR specification.
  /// </summary>
  public static class DefinitionResourceTypesCodes
  {
    /// <summary>
    /// This resource allows for the definition of some activity to be performed, independent of a particular patient, practitioner, or other performance context.
    /// </summary>
    public static readonly Coding ActivityDefinition = new Coding
    {
      Code = "ActivityDefinition",
      Display = "ActivityDefinition",
      System = "http://hl7.org/fhir/definition-resource-types"
    };
    /// <summary>
    /// The EventDefinition resource provides a reusable description of when a particular event can occur.
    /// </summary>
    public static readonly Coding EventDefinition = new Coding
    {
      Code = "EventDefinition",
      Display = "EventDefinition",
      System = "http://hl7.org/fhir/definition-resource-types"
    };
    /// <summary>
    /// The Measure resource provides the definition of a quality measure.
    /// </summary>
    public static readonly Coding Measure = new Coding
    {
      Code = "Measure",
      Display = "Measure",
      System = "http://hl7.org/fhir/definition-resource-types"
    };
    /// <summary>
    /// A formal computable definition of an operation (on the RESTful interface) or a named query (using the search interaction).
    /// </summary>
    public static readonly Coding OperationDefinition = new Coding
    {
      Code = "OperationDefinition",
      Display = "OperationDefinition",
      System = "http://hl7.org/fhir/definition-resource-types"
    };
    /// <summary>
    /// This resource allows for the definition of various types of plans as a sharable, consumable, and executable artifact. The resource is general enough to support the description of a broad range of clinical artifacts such as clinical decision support rules, order sets and protocols.
    /// </summary>
    public static readonly Coding PlanDefinition = new Coding
    {
      Code = "PlanDefinition",
      Display = "PlanDefinition",
      System = "http://hl7.org/fhir/definition-resource-types"
    };
    /// <summary>
    /// A structured set of questions intended to guide the collection of answers from end-users. Questionnaires provide detailed control over order, presentation, phraseology and grouping to allow coherent, consistent data collection.
    /// </summary>
    public static readonly Coding Questionnaire = new Coding
    {
      Code = "Questionnaire",
      Display = "Questionnaire",
      System = "http://hl7.org/fhir/definition-resource-types"
    };

    /// <summary>
    /// Literal for code: ActivityDefinition
    /// </summary>
    public const string LiteralActivityDefinition = "ActivityDefinition";

    /// <summary>
    /// Literal for code: EventDefinition
    /// </summary>
    public const string LiteralEventDefinition = "EventDefinition";

    /// <summary>
    /// Literal for code: Measure
    /// </summary>
    public const string LiteralMeasure = "Measure";

    /// <summary>
    /// Literal for code: OperationDefinition
    /// </summary>
    public const string LiteralOperationDefinition = "OperationDefinition";

    /// <summary>
    /// Literal for code: PlanDefinition
    /// </summary>
    public const string LiteralPlanDefinition = "PlanDefinition";

    /// <summary>
    /// Literal for code: Questionnaire
    /// </summary>
    public const string LiteralQuestionnaire = "Questionnaire";
  };
}
