using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEmergencyCallNotificationGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "sendEmergencyCallNotificationEmail", IsNullable = false)]
    public bool SendEmergencyCallNotificationEmail { get; set; }
    [XmlElement(ElementName = "emergencyCallNotifyEmailAddress", IsNullable = false)]
    public string EmergencyCallNotifyEmailAddress { get; set; }
 }
}
