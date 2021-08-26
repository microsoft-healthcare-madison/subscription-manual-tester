// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The code(s) that detail the conditions under which the healthcare service is available/offered.
  /// </summary>
  public static class ServiceProvisionConditionsCodes
  {
    /// <summary>
    /// Fees apply for this service.
    /// </summary>
    public static readonly Coding FeesApply = new Coding
    {
      Code = "cost",
      Display = "Fees apply",
      System = "http://terminology.hl7.org/CodeSystem/service-provision-conditions"
    };
    /// <summary>
    /// There are discounts available on this service for qualifying patients.
    /// </summary>
    public static readonly Coding DiscountsAvailable = new Coding
    {
      Code = "disc",
      Display = "Discounts Available",
      System = "http://terminology.hl7.org/CodeSystem/service-provision-conditions"
    };
    /// <summary>
    /// This service is available for no patient cost.
    /// </summary>
    public static readonly Coding Free = new Coding
    {
      Code = "free",
      Display = "Free",
      System = "http://terminology.hl7.org/CodeSystem/service-provision-conditions"
    };

    /// <summary>
    /// Literal for code: FeesApply
    /// </summary>
    public const string LiteralFeesApply = "cost";

    /// <summary>
    /// Literal for code: DiscountsAvailable
    /// </summary>
    public const string LiteralDiscountsAvailable = "disc";

    /// <summary>
    /// Literal for code: Free
    /// </summary>
    public const string LiteralFree = "free";
  };
}
