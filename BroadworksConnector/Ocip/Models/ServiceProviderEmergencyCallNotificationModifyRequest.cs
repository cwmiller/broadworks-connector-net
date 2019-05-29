using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderEmergencyCallNotificationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "sendEmergencyCallNotificationEmail", IsNullable = false)]
    public bool SendEmergencyCallNotificationEmail { get; set; }
    [XmlElement(ElementName = "emergencyCallNotifyEmailAddress", IsNullable = true)]
    public string EmergencyCallNotifyEmailAddress { get; set; }
    [XmlElement(ElementName = "allowGroupOverride", IsNullable = false)]
    public bool AllowGroupOverride { get; set; }
 }
}
