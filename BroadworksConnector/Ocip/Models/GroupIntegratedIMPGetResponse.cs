using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupIntegratedIMPGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _useServiceProviderSetting;

    [XmlElement(ElementName = "useServiceProviderSetting", IsNullable = false, Namespace = "")]
    public bool UseServiceProviderSetting {
        get => _useServiceProviderSetting;
        set {
            UseServiceProviderSettingSpecified = true;
            _useServiceProviderSetting = value;
        }
    }

    [XmlIgnore]
    public bool UseServiceProviderSettingSpecified { get; set; }
    private string _serviceDomain;

    [XmlElement(ElementName = "serviceDomain", IsNullable = false, Namespace = "")]
    public string ServiceDomain {
        get => _serviceDomain;
        set {
            ServiceDomainSpecified = true;
            _serviceDomain = value;
        }
    }

    [XmlIgnore]
    public bool ServiceDomainSpecified { get; set; }
}
}
