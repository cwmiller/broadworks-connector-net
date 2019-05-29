using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PersonalAssistantMenuKeysReadEntry 
{
    [XmlElement(ElementName = "setPresenceToNone", IsNullable = false)]
    public string SetPresenceToNone { get; set; }
    [XmlElement(ElementName = "setPresenceToBusinessTrip", IsNullable = false)]
    public string SetPresenceToBusinessTrip { get; set; }
    [XmlElement(ElementName = "setPresenceToGoneForTheDay", IsNullable = false)]
    public string SetPresenceToGoneForTheDay { get; set; }
    [XmlElement(ElementName = "setPresenceToLunch", IsNullable = false)]
    public string SetPresenceToLunch { get; set; }
    [XmlElement(ElementName = "setPresenceToMeeting", IsNullable = false)]
    public string SetPresenceToMeeting { get; set; }
    [XmlElement(ElementName = "setPresenceToOutOfOffice", IsNullable = false)]
    public string SetPresenceToOutOfOffice { get; set; }
    [XmlElement(ElementName = "setPresenceToTemporarilyOut", IsNullable = false)]
    public string SetPresenceToTemporarilyOut { get; set; }
    [XmlElement(ElementName = "setPresenceToTraining", IsNullable = false)]
    public string SetPresenceToTraining { get; set; }
    [XmlElement(ElementName = "setPresenceToUnavailable", IsNullable = false)]
    public string SetPresenceToUnavailable { get; set; }
    [XmlElement(ElementName = "setPresenceToVacation", IsNullable = false)]
    public string SetPresenceToVacation { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = false)]
    public string RepeatMenu { get; set; }
 }
}
