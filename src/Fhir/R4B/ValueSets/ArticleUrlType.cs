// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Code the reason for different URLs, eg abstract and full-text.
  /// </summary>
  public static class ArticleUrlTypeCodes
  {
    /// <summary>
    /// URL to reach the abstract for the article.
    /// </summary>
    public static readonly Coding Abstract = new Coding
    {
      Code = "abstract",
      Display = "Abstract",
      System = "http://terminology.hl7.org/CodeSystem/article-url-type"
    };
    /// <summary>
    /// URL to reach a specific version of the abstract for the article.
    /// </summary>
    public static readonly Coding AbstractCited = new Coding
    {
      Code = "abstract-cited",
      Display = "Abstract Cited",
      System = "http://terminology.hl7.org/CodeSystem/article-url-type"
    };
    /// <summary>
    /// URL derived from DOI.
    /// </summary>
    public static readonly Coding DOIBased = new Coding
    {
      Code = "DOI-based",
      Display = "DOI Based",
      System = "http://terminology.hl7.org/CodeSystem/article-url-type"
    };
    /// <summary>
    /// URL to reach the full-text of the article.
    /// </summary>
    public static readonly Coding FullText = new Coding
    {
      Code = "full-text",
      Display = "Full-Text",
      System = "http://terminology.hl7.org/CodeSystem/article-url-type"
    };
    /// <summary>
    /// URL to reach a specific version of the full-text of the article.
    /// </summary>
    public static readonly Coding FullTextCited = new Coding
    {
      Code = "full-text-cited",
      Display = "Full-Text Cited",
      System = "http://terminology.hl7.org/CodeSystem/article-url-type"
    };
    /// <summary>
    /// URL to reach computable content in JSON format.
    /// </summary>
    public static readonly Coding JSON = new Coding
    {
      Code = "JSON",
      Display = "JSON",
      System = "http://terminology.hl7.org/CodeSystem/article-url-type"
    };
    /// <summary>
    /// Used when URL type is not specified, commonly when only a single URL is provided.
    /// </summary>
    public static readonly Coding NotSpecified = new Coding
    {
      Code = "not-specified",
      Display = "Not Specified",
      System = "http://terminology.hl7.org/CodeSystem/article-url-type"
    };
    /// <summary>
    /// URL to reach the full-text of the article in PDF form.
    /// </summary>
    public static readonly Coding PDF = new Coding
    {
      Code = "PDF",
      Display = "PDF",
      System = "http://terminology.hl7.org/CodeSystem/article-url-type"
    };
    /// <summary>
    /// URL to reach a specific version of the full-text of the article in PDF form.
    /// </summary>
    public static readonly Coding PDFCited = new Coding
    {
      Code = "PDF-cited",
      Display = "PDF-Cited",
      System = "http://terminology.hl7.org/CodeSystem/article-url-type"
    };
    /// <summary>
    /// URL to reach computable content in XML format.
    /// </summary>
    public static readonly Coding XML = new Coding
    {
      Code = "XML",
      Display = "XML",
      System = "http://terminology.hl7.org/CodeSystem/article-url-type"
    };

    /// <summary>
    /// Literal for code: Abstract
    /// </summary>
    public const string LiteralAbstract = "abstract";

    /// <summary>
    /// Literal for code: AbstractCited
    /// </summary>
    public const string LiteralAbstractCited = "abstract-cited";

    /// <summary>
    /// Literal for code: DOIBased
    /// </summary>
    public const string LiteralDOIBased = "DOI-based";

    /// <summary>
    /// Literal for code: FullText
    /// </summary>
    public const string LiteralFullText = "full-text";

    /// <summary>
    /// Literal for code: FullTextCited
    /// </summary>
    public const string LiteralFullTextCited = "full-text-cited";

    /// <summary>
    /// Literal for code: JSON
    /// </summary>
    public const string LiteralJSON = "JSON";

    /// <summary>
    /// Literal for code: NotSpecified
    /// </summary>
    public const string LiteralNotSpecified = "not-specified";

    /// <summary>
    /// Literal for code: PDF
    /// </summary>
    public const string LiteralPDF = "PDF";

    /// <summary>
    /// Literal for code: PDFCited
    /// </summary>
    public const string LiteralPDFCited = "PDF-cited";

    /// <summary>
    /// Literal for code: XML
    /// </summary>
    public const string LiteralXML = "XML";
  };
}
