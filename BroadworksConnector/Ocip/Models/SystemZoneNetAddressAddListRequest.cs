using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemZoneNetAddressAddListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "zoneName", IsNullable = false)]
    public string ZoneName { get; set; }
    [XmlElement(ElementName = "netAddress", IsNullable = false)]
    public List<string> NetAddress { get; set; }
    [XmlElement(ElementName = "netAddressRange", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.IPAddressRange> NetAddressRange { get; set; }
 }
}
