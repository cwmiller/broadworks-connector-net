using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderRouteListEnterpriseTrunkNumberPrefixAddListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<string> _prefix;

    [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
    public List<string> Prefix {
        get => _prefix;
        set {
            PrefixSpecified = true;
            _prefix = value;
        }
    }

    [XmlIgnore]
    public bool PrefixSpecified { get; set; }
}
}
