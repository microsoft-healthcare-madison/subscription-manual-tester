// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Overall defining type of this clinical use issue.
  /// </summary>
  public static class ClinicalUseIssueTypeCodes
  {
    /// <summary>
    /// A reason for not giving the medicaition.
    /// </summary>
    public static readonly Coding Contraindication = new Coding
    {
      Code = "contraindication",
      Display = "Contraindication",
      System = "http://hl7.org/fhir/clinical-use-issue-type"
    };
    /// <summary>
    /// A reason for giving the medicaton.
    /// </summary>
    public static readonly Coding Indication = new Coding
    {
      Code = "indication",
      Display = "Indication",
      System = "http://hl7.org/fhir/clinical-use-issue-type"
    };
    /// <summary>
    /// Interactions between the medication and other substances.
    /// </summary>
    public static readonly Coding Interaction = new Coding
    {
      Code = "interaction",
      Display = "Interaction",
      System = "http://hl7.org/fhir/clinical-use-issue-type"
    };
    /// <summary>
    /// Side effects or adverse effects associated with the medication.
    /// </summary>
    public static readonly Coding UndesirableEffect = new Coding
    {
      Code = "undesirable-effect",
      Display = "Undesirable Effect",
      System = "http://hl7.org/fhir/clinical-use-issue-type"
    };
    /// <summary>
    /// A general warning or issue that is not specifically one of the other types.
    /// </summary>
    public static readonly Coding Warning = new Coding
    {
      Code = "warning",
      Display = "Warning",
      System = "http://hl7.org/fhir/clinical-use-issue-type"
    };

    /// <summary>
    /// Literal for code: Contraindication
    /// </summary>
    public const string LiteralContraindication = "contraindication";

    /// <summary>
    /// Literal for code: Indication
    /// </summary>
    public const string LiteralIndication = "indication";

    /// <summary>
    /// Literal for code: Interaction
    /// </summary>
    public const string LiteralInteraction = "interaction";

    /// <summary>
    /// Literal for code: UndesirableEffect
    /// </summary>
    public const string LiteralUndesirableEffect = "undesirable-effect";

    /// <summary>
    /// Literal for code: Warning
    /// </summary>
    public const string LiteralWarning = "warning";
  };
}
