using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21VoiceMessagingMenuKeys 
{
    [XmlElement(ElementName = "playMessages", IsNullable = false)]
    public string PlayMessages { get; set; }
    [XmlElement(ElementName = "changeBusyGreeting", IsNullable = false)]
    public string ChangeBusyGreeting { get; set; }
    [XmlElement(ElementName = "changeNoAnswerGreeting", IsNullable = false)]
    public string ChangeNoAnswerGreeting { get; set; }
    [XmlElement(ElementName = "changeExtendedAwayGreeting", IsNullable = false)]
    public string ChangeExtendedAwayGreeting { get; set; }
    [XmlElement(ElementName = "composeMessage", IsNullable = false)]
    public string ComposeMessage { get; set; }
    [XmlElement(ElementName = "deleteAllMessages", IsNullable = false)]
    public string DeleteAllMessages { get; set; }
    [XmlElement(ElementName = "passcode", IsNullable = false)]
    public string Passcode { get; set; }
    [XmlElement(ElementName = "personalizedName", IsNullable = false)]
    public string PersonalizedName { get; set; }
    [XmlElement(ElementName = "messageDeposit", IsNullable = false)]
    public string MessageDeposit { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = false)]
    public string RepeatMenu { get; set; }
 }
}
