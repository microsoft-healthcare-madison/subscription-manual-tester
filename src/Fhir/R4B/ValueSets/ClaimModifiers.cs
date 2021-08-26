// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes sample Modifier type codes.
  /// </summary>
  public static class ClaimModifiersCodes
  {
    /// <summary>
    /// Repair of prior service or installation.
    /// </summary>
    public static readonly Coding RepairOfPriorServiceOrInstallation = new Coding
    {
      Code = "a",
      Display = "Repair of prior service or installation",
      System = "http://terminology.hl7.org/CodeSystem/modifiers"
    };
    /// <summary>
    /// Temporary service or installation.
    /// </summary>
    public static readonly Coding TemporaryServiceOrInstallation = new Coding
    {
      Code = "b",
      Display = "Temporary service or installation",
      System = "http://terminology.hl7.org/CodeSystem/modifiers"
    };
    /// <summary>
    /// Treatment associated with TMJ.
    /// </summary>
    public static readonly Coding TMJTreatment = new Coding
    {
      Code = "c",
      Display = "TMJ treatment",
      System = "http://terminology.hl7.org/CodeSystem/modifiers"
    };
    /// <summary>
    /// Implant or associated with an implant.
    /// </summary>
    public static readonly Coding ImplantOrAssociatedWithAnImplant = new Coding
    {
      Code = "e",
      Display = "Implant or associated with an implant",
      System = "http://terminology.hl7.org/CodeSystem/modifiers"
    };
    /// <summary>
    /// A Rush service or service performed outside of normal office hours.
    /// </summary>
    public static readonly Coding RushOrOutsideOfOfficeHours = new Coding
    {
      Code = "rooh",
      Display = "Rush or Outside of office hours",
      System = "http://terminology.hl7.org/CodeSystem/modifiers"
    };
    /// <summary>
    /// None.
    /// </summary>
    public static readonly Coding None = new Coding
    {
      Code = "x",
      Display = "None",
      System = "http://terminology.hl7.org/CodeSystem/modifiers"
    };

    /// <summary>
    /// Literal for code: RepairOfPriorServiceOrInstallation
    /// </summary>
    public const string LiteralRepairOfPriorServiceOrInstallation = "a";

    /// <summary>
    /// Literal for code: TemporaryServiceOrInstallation
    /// </summary>
    public const string LiteralTemporaryServiceOrInstallation = "b";

    /// <summary>
    /// Literal for code: TMJTreatment
    /// </summary>
    public const string LiteralTMJTreatment = "c";

    /// <summary>
    /// Literal for code: ImplantOrAssociatedWithAnImplant
    /// </summary>
    public const string LiteralImplantOrAssociatedWithAnImplant = "e";

    /// <summary>
    /// Literal for code: RushOrOutsideOfOfficeHours
    /// </summary>
    public const string LiteralRushOrOutsideOfOfficeHours = "rooh";

    /// <summary>
    /// Literal for code: None
    /// </summary>
    public const string LiteralNone = "x";
  };
}