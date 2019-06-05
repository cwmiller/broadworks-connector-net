using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLanguageAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _language;

    [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
    public string Language {
        get => _language;
        set {
            LanguageSpecified = true;
            _language = value;
        }
    }

    [XmlIgnore]
    public bool LanguageSpecified { get; set; }
    private string _locale;

    [XmlElement(ElementName = "locale", IsNullable = false, Namespace = "")]
    public string Locale {
        get => _locale;
        set {
            LocaleSpecified = true;
            _locale = value;
        }
    }

    [XmlIgnore]
    public bool LocaleSpecified { get; set; }
    private string _encoding;

    [XmlElement(ElementName = "encoding", IsNullable = false, Namespace = "")]
    public string Encoding {
        get => _encoding;
        set {
            EncodingSpecified = true;
            _encoding = value;
        }
    }

    [XmlIgnore]
    public bool EncodingSpecified { get; set; }
}
}
