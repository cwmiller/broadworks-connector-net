using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderBroadWorksCommunicatorModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _configurationServerURL;

    [XmlElement(ElementName = "configurationServerURL", IsNullable = true, Namespace = "")]
    public string ConfigurationServerURL {
        get => _configurationServerURL;
        set {
            ConfigurationServerURLSpecified = true;
            _configurationServerURL = value;
        }
    }

    [XmlIgnore]
    public bool ConfigurationServerURLSpecified { get; set; }
}
}
