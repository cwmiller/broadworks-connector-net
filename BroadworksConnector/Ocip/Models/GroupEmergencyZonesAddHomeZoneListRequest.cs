using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEmergencyZonesAddHomeZoneListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "homeZoneIpAddress", IsNullable = false)]
    public List<string> HomeZoneIpAddress { get; set; }
    [XmlElement(ElementName = "homeZoneIpAddressRange", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.IPAddressRange> HomeZoneIpAddressRange { get; set; }
 }
}
