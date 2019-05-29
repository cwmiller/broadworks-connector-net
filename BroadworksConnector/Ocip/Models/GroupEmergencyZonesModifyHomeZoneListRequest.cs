using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEmergencyZonesModifyHomeZoneListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "homeZoneIpAddressList", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressList> HomeZoneIpAddressList { get; set; }
    [XmlElement(ElementName = "homeZoneIpAddressRangeList", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressRangeList> HomeZoneIpAddressRangeList { get; set; }
 }
}
