using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupNetworkClassOfServiceAssignListRequest21 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public List<string> NetworkClassOfService { get; set; }
    [XmlElement(ElementName = "defaultNetworkClassOfService", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DefaultNetworkClassOfService DefaultNetworkClassOfService { get; set; }
 }
}
