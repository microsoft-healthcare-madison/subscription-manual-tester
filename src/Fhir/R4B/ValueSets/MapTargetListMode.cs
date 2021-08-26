// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// If field is a list, how to manage the production.
  /// </summary>
  public static class MapTargetListModeCodes
  {
    /// <summary>
    /// re-use the first item in the list, and keep adding content to it.
    /// </summary>
    public static readonly Coding Collate = new Coding
    {
      Code = "collate",
      Display = "Collate",
      System = "http://hl7.org/fhir/map-target-list-mode"
    };
    /// <summary>
    /// when the target list is being assembled, the items for this rule go first. If more than one rule defines a first item (for a given instance of mapping) then this is an error.
    /// </summary>
    public static readonly Coding First = new Coding
    {
      Code = "first",
      Display = "First",
      System = "http://hl7.org/fhir/map-target-list-mode"
    };
    /// <summary>
    /// when the target list is being assembled, the items for this rule go last. If more than one rule defines a last item (for a given instance of mapping) then this is an error.
    /// </summary>
    public static readonly Coding Last = new Coding
    {
      Code = "last",
      Display = "Last",
      System = "http://hl7.org/fhir/map-target-list-mode"
    };
    /// <summary>
    /// the target instance is shared with the target instances generated by another rule (up to the first common n items, then create new ones).
    /// </summary>
    public static readonly Coding Share = new Coding
    {
      Code = "share",
      Display = "Share",
      System = "http://hl7.org/fhir/map-target-list-mode"
    };

    /// <summary>
    /// Literal for code: Collate
    /// </summary>
    public const string LiteralCollate = "collate";

    /// <summary>
    /// Literal for code: First
    /// </summary>
    public const string LiteralFirst = "first";

    /// <summary>
    /// Literal for code: Last
    /// </summary>
    public const string LiteralLast = "last";

    /// <summary>
    /// Literal for code: Share
    /// </summary>
    public const string LiteralShare = "share";
  };
}
