using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointList 
{
    [XmlElement(ElementName = "sharedCallAppearanceAccessDeviceEndpoint", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint> SharedCallAppearanceAccessDeviceEndpoint { get; set; }
 }
}
