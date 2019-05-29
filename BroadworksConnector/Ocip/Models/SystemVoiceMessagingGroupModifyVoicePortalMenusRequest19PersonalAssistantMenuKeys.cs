using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PersonalAssistantMenuKeys 
{
    [XmlElement(ElementName = "setPresenceToNone", IsNullable = true)]
    public string SetPresenceToNone { get; set; }
    [XmlElement(ElementName = "setPresenceToBusinessTrip", IsNullable = true)]
    public string SetPresenceToBusinessTrip { get; set; }
    [XmlElement(ElementName = "setPresenceToGoneForTheDay", IsNullable = true)]
    public string SetPresenceToGoneForTheDay { get; set; }
    [XmlElement(ElementName = "setPresenceToLunch", IsNullable = true)]
    public string SetPresenceToLunch { get; set; }
    [XmlElement(ElementName = "setPresenceToMeeting", IsNullable = true)]
    public string SetPresenceToMeeting { get; set; }
    [XmlElement(ElementName = "setPresenceToOutOfOffice", IsNullable = true)]
    public string SetPresenceToOutOfOffice { get; set; }
    [XmlElement(ElementName = "setPresenceToTemporarilyOut", IsNullable = true)]
    public string SetPresenceToTemporarilyOut { get; set; }
    [XmlElement(ElementName = "setPresenceToTraining", IsNullable = true)]
    public string SetPresenceToTraining { get; set; }
    [XmlElement(ElementName = "setPresenceToUnavailable", IsNullable = true)]
    public string SetPresenceToUnavailable { get; set; }
    [XmlElement(ElementName = "setPresenceToVacation", IsNullable = true)]
    public string SetPresenceToVacation { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = true)]
    public string RepeatMenu { get; set; }
 }
}
