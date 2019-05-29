using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressList 
{
    [XmlElement(ElementName = "homeZoneIpAddress", IsNullable = false)]
    public string HomeZoneIpAddress { get; set; }
    [XmlElement(ElementName = "newHomeZoneIpAddress", IsNullable = false)]
    public string NewHomeZoneIpAddress { get; set; }
 }
}
