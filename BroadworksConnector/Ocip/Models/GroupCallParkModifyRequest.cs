using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallParkModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "recallTimerSeconds", IsNullable = false)]
    public int RecallTimerSeconds { get; set; }
    [XmlElement(ElementName = "displayTimerSeconds", IsNullable = false)]
    public int DisplayTimerSeconds { get; set; }
    [XmlElement(ElementName = "enableDestinationAnnouncement", IsNullable = false)]
    public bool EnableDestinationAnnouncement { get; set; }
    [XmlElement(ElementName = "recallAlternateUserId", IsNullable = true)]
    public string RecallAlternateUserId { get; set; }
    [XmlElement(ElementName = "recallRingPattern", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RingPattern RecallRingPattern { get; set; }
    [XmlElement(ElementName = "recallTo", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallParkRecallTo RecallTo { get; set; }
    [XmlElement(ElementName = "alternateUserRecallTimerSeconds", IsNullable = false)]
    public int AlternateUserRecallTimerSeconds { get; set; }
 }
}
