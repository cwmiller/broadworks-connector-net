using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressRangeList 
{
    [XmlElement(ElementName = "homeZoneIpAddressRange", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.IPAddressRange HomeZoneIpAddressRange { get; set; }
    [XmlElement(ElementName = "newHomeZoneIpAddressRange", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.IPAddressRange NewHomeZoneIpAddressRange { get; set; }
 }
}
