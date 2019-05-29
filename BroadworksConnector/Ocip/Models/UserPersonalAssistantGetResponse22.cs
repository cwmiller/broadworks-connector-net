using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPersonalAssistantGetResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "presence", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PersonalAssistantPresence Presence { get; set; }
    [XmlElement(ElementName = "enableTransferToAttendant", IsNullable = false)]
    public bool EnableTransferToAttendant { get; set; }
    [XmlElement(ElementName = "attendantNumber", IsNullable = false)]
    public string AttendantNumber { get; set; }
    [XmlElement(ElementName = "enableRingSplash", IsNullable = false)]
    public bool EnableRingSplash { get; set; }
    [XmlElement(ElementName = "enableExpirationTime", IsNullable = false)]
    public bool EnableExpirationTime { get; set; }
    [XmlElement(ElementName = "expirationTime", IsNullable = false)]
    public string ExpirationTime { get; set; }
    [XmlElement(ElementName = "alertMeFirst", IsNullable = false)]
    public bool AlertMeFirst { get; set; }
    [XmlElement(ElementName = "alertMeFirstNumberOfRings", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PersonalAssistantAlertMeFirstNumberOfRings AlertMeFirstNumberOfRings { get; set; }
 }
}
