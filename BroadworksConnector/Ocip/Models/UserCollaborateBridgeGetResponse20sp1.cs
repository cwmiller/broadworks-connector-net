using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCollaborateBridgeGetResponse20sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "bridgeId", IsNullable = false)]
    public string BridgeId { get; set; }
    [XmlElement(ElementName = "bridgeName", IsNullable = false)]
    public string BridgeName { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "extension", IsNullable = false)]
    public string Extension { get; set; }
    [XmlElement(ElementName = "alternateNumberEntry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AlternateNumberEntry21> AlternateNumberEntry { get; set; }
    [XmlElement(ElementName = "supportOutDial", IsNullable = false)]
    public bool SupportOutDial { get; set; }
    [XmlElement(ElementName = "maxCollaborateRoomParticipants", IsNullable = false)]
    public int MaxCollaborateRoomParticipants { get; set; }
 }
}
