using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEmergencyZonesGetHomeZoneListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "homeZoneIpAddress", IsNullable = false)]
    public List<string> HomeZoneIpAddress { get; set; }
    [XmlElement(ElementName = "homeZoneIpAddressRange", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.IPAddressRange> HomeZoneIpAddressRange { get; set; }
 }
}
