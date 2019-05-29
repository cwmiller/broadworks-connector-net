using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEmergencyCallNotificationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "sendEmergencyCallNotificationEmail", IsNullable = false)]
    public bool SendEmergencyCallNotificationEmail { get; set; }
    [XmlElement(ElementName = "emergencyCallNotifyEmailAddress", IsNullable = true)]
    public string EmergencyCallNotifyEmailAddress { get; set; }
 }
}
