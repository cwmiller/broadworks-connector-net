using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointList 
{
    private List<BroadworksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint> _sharedCallAppearanceAccessDeviceEndpoint;

    [XmlElement(ElementName = "sharedCallAppearanceAccessDeviceEndpoint", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint> SharedCallAppearanceAccessDeviceEndpoint {
        get => _sharedCallAppearanceAccessDeviceEndpoint;
        set {
            SharedCallAppearanceAccessDeviceEndpointSpecified = true;
            _sharedCallAppearanceAccessDeviceEndpoint = value;
        }
    }

    [XmlIgnore]
    public bool SharedCallAppearanceAccessDeviceEndpointSpecified { get; set; }
}
}
