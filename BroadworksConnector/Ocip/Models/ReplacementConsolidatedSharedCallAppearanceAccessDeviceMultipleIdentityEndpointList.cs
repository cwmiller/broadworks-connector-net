using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointList 
{
    private List<BroadWorksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint> _sharedCallAppearanceAccessDeviceEndpoint;

    [XmlElement(ElementName = "sharedCallAppearanceAccessDeviceEndpoint", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint> SharedCallAppearanceAccessDeviceEndpoint {
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
