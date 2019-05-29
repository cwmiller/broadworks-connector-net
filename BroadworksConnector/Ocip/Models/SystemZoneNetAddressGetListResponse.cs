using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemZoneNetAddressGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "netAddress", IsNullable = false)]
    public List<string> NetAddress { get; set; }
    [XmlElement(ElementName = "netAddressRange", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.IPAddressRange> NetAddressRange { get; set; }
 }
}
