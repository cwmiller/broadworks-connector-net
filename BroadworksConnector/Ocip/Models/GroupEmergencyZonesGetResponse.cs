using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEmergencyZonesGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "emergencyZonesProhibition", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EmergencyZonesProhibition EmergencyZonesProhibition { get; set; }
    [XmlElement(ElementName = "sendEmergencyCallNotifyEmail", IsNullable = false)]
    public bool SendEmergencyCallNotifyEmail { get; set; }
    [XmlElement(ElementName = "emergencyCallNotifyEmailAddress", IsNullable = false)]
    public string EmergencyCallNotifyEmailAddress { get; set; }
 }
}
