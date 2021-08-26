// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Codes defining the purpose of a Questionnaire item of type 'text'.
  /// </summary>
  public static class QuestionnaireDisplayCategoryCodes
  {
    /// <summary>
    /// The text provides additional guidance on populating the containing item.  Help text isn't necessarily expected to be rendered as part of the form, but may instead be made available through fly-over, pop-up button, link to a "help" page, etc.
    /// </summary>
    public static readonly Coding Help = new Coding
    {
      Code = "help",
      Display = "Help",
      System = "http://hl7.org/fhir/questionnaire-display-category"
    };
    /// <summary>
    /// The text provides guidance on how to populate or use a portion of the questionnaire (or the questionnaire as a whole).
    /// </summary>
    public static readonly Coding Instructions = new Coding
    {
      Code = "instructions",
      Display = "Instructions",
      System = "http://hl7.org/fhir/questionnaire-display-category"
    };
    /// <summary>
    /// The text provides guidance on how the information should be or will be handled from a security/confidentiality/access control perspective when completed
    /// </summary>
    public static readonly Coding Security = new Coding
    {
      Code = "security",
      Display = "Security",
      System = "http://hl7.org/fhir/questionnaire-display-category"
    };

    /// <summary>
    /// Literal for code: Help
    /// </summary>
    public const string LiteralHelp = "help";

    /// <summary>
    /// Literal for code: Instructions
    /// </summary>
    public const string LiteralInstructions = "instructions";

    /// <summary>
    /// Literal for code: Security
    /// </summary>
    public const string LiteralSecurity = "security";
  };
}
