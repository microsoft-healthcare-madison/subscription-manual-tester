// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes sample Claim SubType codes which are used to distinguish the claim types for example within type institutional there may be subtypes for emergency services, bed stay and transportation.
  /// </summary>
  public static class ClaimSubtypeCodes
  {
    /// <summary>
    /// A claim for emergency services.
    /// </summary>
    public static readonly Coding EmergencyClaim = new Coding
    {
      Code = "emergency",
      Display = "Emergency Claim",
      System = "http://terminology.hl7.org/CodeSystem/ex-claimsubtype"
    };
    /// <summary>
    /// A claim for Orthodontic Services.
    /// </summary>
    public static readonly Coding OrthodonticClaim = new Coding
    {
      Code = "ortho",
      Display = "Orthodontic Claim",
      System = "http://terminology.hl7.org/CodeSystem/ex-claimsubtype"
    };

    /// <summary>
    /// Literal for code: EmergencyClaim
    /// </summary>
    public const string LiteralEmergencyClaim = "emergency";

    /// <summary>
    /// Literal for code: OrthodonticClaim
    /// </summary>
    public const string LiteralOrthodonticClaim = "ortho";
  };
}
