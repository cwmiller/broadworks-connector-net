using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCombinedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointList 
{
    [XmlElement(ElementName = "sharedCallAppearanceAccessDeviceEndpoint", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CombinedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint> SharedCallAppearanceAccessDeviceEndpoint { get; set; }
 }
}
