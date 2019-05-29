using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCollaborateModifyRequest20sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "collaborateRoomIdLength", IsNullable = false)]
    public int CollaborateRoomIdLength { get; set; }
    [XmlElement(ElementName = "instantRoomIdleTimeoutSeconds", IsNullable = false)]
    public int InstantRoomIdleTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "collaborateRoomMaximumDurationMinutes", IsNullable = false)]
    public int CollaborateRoomMaximumDurationMinutes { get; set; }
    [XmlElement(ElementName = "supportOutdial", IsNullable = false)]
    public bool SupportOutdial { get; set; }
    [XmlElement(ElementName = "maxCollaborateRoomParticipants", IsNullable = false)]
    public int MaxCollaborateRoomParticipants { get; set; }
    [XmlElement(ElementName = "collaborateActiveTalkerRefreshIntervalSeconds", IsNullable = false)]
    public int CollaborateActiveTalkerRefreshIntervalSeconds { get; set; }
    [XmlElement(ElementName = "terminateCollaborateAfterGracePeriod", IsNullable = false)]
    public bool TerminateCollaborateAfterGracePeriod { get; set; }
    [XmlElement(ElementName = "collaborateGracePeriod", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CollaborateGracePeriodDuration CollaborateGracePeriod { get; set; }
    [XmlElement(ElementName = "enableActiveCollaborateNotification", IsNullable = false)]
    public bool EnableActiveCollaborateNotification { get; set; }
    [XmlElement(ElementName = "collaborateFromAddress", IsNullable = true)]
    public string CollaborateFromAddress { get; set; }
 }
}
