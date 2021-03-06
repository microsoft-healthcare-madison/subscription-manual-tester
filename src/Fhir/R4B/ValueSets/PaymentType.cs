// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes sample Payment Type codes.
  /// </summary>
  public static class PaymentTypeCodes
  {
    /// <summary>
    /// The amount is an adjustment regarding claims already paid.
    /// </summary>
    public static readonly Coding Adjustment = new Coding
    {
      Code = "adjustment",
      Display = "Adjustment",
      System = "http://terminology.hl7.org/CodeSystem/payment-type"
    };
    /// <summary>
    /// The amount is an advance against future claims.
    /// </summary>
    public static readonly Coding Advance = new Coding
    {
      Code = "advance",
      Display = "Advance",
      System = "http://terminology.hl7.org/CodeSystem/payment-type"
    };
    /// <summary>
    /// The amount is partial or complete settlement of the amounts due.
    /// </summary>
    public static readonly Coding Payment = new Coding
    {
      Code = "payment",
      Display = "Payment",
      System = "http://terminology.hl7.org/CodeSystem/payment-type"
    };

    /// <summary>
    /// Literal for code: Adjustment
    /// </summary>
    public const string LiteralAdjustment = "adjustment";

    /// <summary>
    /// Literal for code: Advance
    /// </summary>
    public const string LiteralAdvance = "advance";

    /// <summary>
    /// Literal for code: Payment
    /// </summary>
    public const string LiteralPayment = "payment";
  };
}
