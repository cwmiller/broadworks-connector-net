using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeLanguageMappingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _deviceType;

    [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
    public string DeviceType {
        get => _deviceType;
        set {
            DeviceTypeSpecified = true;
            _deviceType = value;
        }
    }

    [XmlIgnore]
    public bool DeviceTypeSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.DeviceManagementLanguageMapping> _languageMapping;

    [XmlElement(ElementName = "languageMapping", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.DeviceManagementLanguageMapping> LanguageMapping {
        get => _languageMapping;
        set {
            LanguageMappingSpecified = true;
            _languageMapping = value;
        }
    }

    [XmlIgnore]
    public bool LanguageMappingSpecified { get; set; }
}
}
