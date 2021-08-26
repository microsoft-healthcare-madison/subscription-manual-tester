// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes a smattering of Benefit type codes.
  /// </summary>
  public static class BenefitTypeCodes
  {
    /// <summary>
    /// Maximum benefit allowable.
    /// </summary>
    public static readonly Coding Benefit = new Coding
    {
      Code = "benefit",
      Display = "Benefit",
      System = "http://terminology.hl7.org/CodeSystem/benefit-type"
    };
    /// <summary>
    /// Copayment per service
    /// </summary>
    public static readonly Coding CopaymentPerService = new Coding
    {
      Code = "copay",
      Display = "Copayment per service",
      System = "http://terminology.hl7.org/CodeSystem/benefit-type"
    };
    /// <summary>
    /// Copayment maximum per service
    /// </summary>
    public static readonly Coding CopaymentMaximumPerService = new Coding
    {
      Code = "copay-maximum",
      Display = "Copayment maximum per service",
      System = "http://terminology.hl7.org/CodeSystem/benefit-type"
    };
    /// <summary>
    /// Copayment percentage per service
    /// </summary>
    public static readonly Coding CopaymentPercentPerService = new Coding
    {
      Code = "copay-percent",
      Display = "Copayment Percent per service",
      System = "http://terminology.hl7.org/CodeSystem/benefit-type"
    };
    /// <summary>
    /// Cost to be incurred before benefits are applied
    /// </summary>
    public static readonly Coding Deductible = new Coding
    {
      Code = "deductible",
      Display = "Deductible",
      System = "http://terminology.hl7.org/CodeSystem/benefit-type"
    };
    /// <summary>
    /// Medical Primary Health Coverage
    /// </summary>
    public static readonly Coding MedicalPrimaryHealthCoverage = new Coding
    {
      Code = "medical-primarycare",
      Display = "Medical Primary Health Coverage",
      System = "http://terminology.hl7.org/CodeSystem/benefit-type"
    };
    /// <summary>
    /// Pharmacy Dispense Coverage
    /// </summary>
    public static readonly Coding PharmacyDispenseCoverage = new Coding
    {
      Code = "pharmacy-dispense",
      Display = "Pharmacy Dispense Coverage",
      System = "http://terminology.hl7.org/CodeSystem/benefit-type"
    };
    /// <summary>
    /// Type of room
    /// </summary>
    public static readonly Coding Room = new Coding
    {
      Code = "room",
      Display = "Room",
      System = "http://terminology.hl7.org/CodeSystem/benefit-type"
    };
    /// <summary>
    /// Contact Lenses
    /// </summary>
    public static readonly Coding VisionContactsCoverage = new Coding
    {
      Code = "vision-contacts",
      Display = "Vision Contacts Coverage",
      System = "http://terminology.hl7.org/CodeSystem/benefit-type"
    };
    /// <summary>
    /// Vision Exam
    /// </summary>
    public static readonly Coding VisionExam = new Coding
    {
      Code = "vision-exam",
      Display = "Vision Exam",
      System = "http://terminology.hl7.org/CodeSystem/benefit-type"
    };
    /// <summary>
    /// Frames and lenses
    /// </summary>
    public static readonly Coding VisionGlasses = new Coding
    {
      Code = "vision-glasses",
      Display = "Vision Glasses",
      System = "http://terminology.hl7.org/CodeSystem/benefit-type"
    };
    /// <summary>
    /// Service visit
    /// </summary>
    public static readonly Coding Visit = new Coding
    {
      Code = "visit",
      Display = "Visit",
      System = "http://terminology.hl7.org/CodeSystem/benefit-type"
    };

    /// <summary>
    /// Literal for code: Benefit
    /// </summary>
    public const string LiteralBenefit = "benefit";

    /// <summary>
    /// Literal for code: CopaymentPerService
    /// </summary>
    public const string LiteralCopaymentPerService = "copay";

    /// <summary>
    /// Literal for code: CopaymentMaximumPerService
    /// </summary>
    public const string LiteralCopaymentMaximumPerService = "copay-maximum";

    /// <summary>
    /// Literal for code: CopaymentPercentPerService
    /// </summary>
    public const string LiteralCopaymentPercentPerService = "copay-percent";

    /// <summary>
    /// Literal for code: Deductible
    /// </summary>
    public const string LiteralDeductible = "deductible";

    /// <summary>
    /// Literal for code: MedicalPrimaryHealthCoverage
    /// </summary>
    public const string LiteralMedicalPrimaryHealthCoverage = "medical-primarycare";

    /// <summary>
    /// Literal for code: PharmacyDispenseCoverage
    /// </summary>
    public const string LiteralPharmacyDispenseCoverage = "pharmacy-dispense";

    /// <summary>
    /// Literal for code: Room
    /// </summary>
    public const string LiteralRoom = "room";

    /// <summary>
    /// Literal for code: VisionContactsCoverage
    /// </summary>
    public const string LiteralVisionContactsCoverage = "vision-contacts";

    /// <summary>
    /// Literal for code: VisionExam
    /// </summary>
    public const string LiteralVisionExam = "vision-exam";

    /// <summary>
    /// Literal for code: VisionGlasses
    /// </summary>
    public const string LiteralVisionGlasses = "vision-glasses";

    /// <summary>
    /// Literal for code: Visit
    /// </summary>
    public const string LiteralVisit = "visit";
  };
}
