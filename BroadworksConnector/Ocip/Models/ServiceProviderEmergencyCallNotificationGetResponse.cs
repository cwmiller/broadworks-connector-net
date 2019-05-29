using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderEmergencyCallNotificationGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "sendEmergencyCallNotificationEmail", IsNullable = false)]
    public bool SendEmergencyCallNotificationEmail { get; set; }
    [XmlElement(ElementName = "emergencyCallNotifyEmailAddress", IsNullable = false)]
    public string EmergencyCallNotifyEmailAddress { get; set; }
    [XmlElement(ElementName = "allowGroupOverride", IsNullable = false)]
    public bool AllowGroupOverride { get; set; }
 }
}
