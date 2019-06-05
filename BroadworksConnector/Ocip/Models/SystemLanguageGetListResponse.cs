using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLanguageGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _defaultLanguage;

    [XmlElement(ElementName = "defaultLanguage", IsNullable = false, Namespace = "")]
    public string DefaultLanguage {
        get => _defaultLanguage;
        set {
            DefaultLanguageSpecified = true;
            _defaultLanguage = value;
        }
    }

    [XmlIgnore]
    public bool DefaultLanguageSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _languageTable;

    [XmlElement(ElementName = "languageTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable LanguageTable {
        get => _languageTable;
        set {
            LanguageTableSpecified = true;
            _languageTable = value;
        }
    }

    [XmlIgnore]
    public bool LanguageTableSpecified { get; set; }
}
}
