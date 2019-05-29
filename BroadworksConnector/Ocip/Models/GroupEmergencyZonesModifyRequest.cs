using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEmergencyZonesModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "emergencyZonesProhibition", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EmergencyZonesProhibition EmergencyZonesProhibition { get; set; }
    [XmlElement(ElementName = "sendEmergencyCallNotifyEmail", IsNullable = false)]
    public bool SendEmergencyCallNotifyEmail { get; set; }
    [XmlElement(ElementName = "emergencyCallNotifyEmailAddress", IsNullable = true)]
    public string EmergencyCallNotifyEmailAddress { get; set; }
 }
}
