using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerNetworkClassOfServiceUnassignListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _resellerId;

    [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
    public string ResellerId {
        get => _resellerId;
        set {
            ResellerIdSpecified = true;
            _resellerId = value;
        }
    }

    [XmlIgnore]
    public bool ResellerIdSpecified { get; set; }
    private List<string> _networkClassOfService;

    [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
    public List<string> NetworkClassOfService {
        get => _networkClassOfService;
        set {
            NetworkClassOfServiceSpecified = true;
            _networkClassOfService = value;
        }
    }

    [XmlIgnore]
    public bool NetworkClassOfServiceSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.DefaultNetworkClassOfService _defaultNetworkClassOfService;

    [XmlElement(ElementName = "defaultNetworkClassOfService", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.DefaultNetworkClassOfService DefaultNetworkClassOfService {
        get => _defaultNetworkClassOfService;
        set {
            DefaultNetworkClassOfServiceSpecified = true;
            _defaultNetworkClassOfService = value;
        }
    }

    [XmlIgnore]
    public bool DefaultNetworkClassOfServiceSpecified { get; set; }
}
}
