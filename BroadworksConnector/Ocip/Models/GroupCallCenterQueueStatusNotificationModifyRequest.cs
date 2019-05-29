using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterQueueStatusNotificationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "enableQueueStatusNotification", IsNullable = false)]
    public bool EnableQueueStatusNotification { get; set; }
    [XmlElement(ElementName = "enableQueueDepthThreshold", IsNullable = false)]
    public bool EnableQueueDepthThreshold { get; set; }
    [XmlElement(ElementName = "enableWaitingTimeThreshold", IsNullable = false)]
    public bool EnableWaitingTimeThreshold { get; set; }
    [XmlElement(ElementName = "numberOfCallsThreshold", IsNullable = false)]
    public int NumberOfCallsThreshold { get; set; }
    [XmlElement(ElementName = "waitingTimeOfCallsThreshold", IsNullable = false)]
    public int WaitingTimeOfCallsThreshold { get; set; }
 }
}
