using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerNetworkClassOfServiceUnassignListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "resellerId", IsNullable = false)]
    public string ResellerId { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public List<string> NetworkClassOfService { get; set; }
    [XmlElement(ElementName = "defaultNetworkClassOfService", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.DefaultNetworkClassOfService DefaultNetworkClassOfService { get; set; }
 }
}
