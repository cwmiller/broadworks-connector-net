using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class VoiceMessagingMenuKeysModifyEntry 
{
    [XmlElement(ElementName = "playMessages", IsNullable = true)]
    public string PlayMessages { get; set; }
    [XmlElement(ElementName = "changeBusyGreeting", IsNullable = true)]
    public string ChangeBusyGreeting { get; set; }
    [XmlElement(ElementName = "changeNoAnswerGreeting", IsNullable = true)]
    public string ChangeNoAnswerGreeting { get; set; }
    [XmlElement(ElementName = "changeExtendedAwayGreeting", IsNullable = true)]
    public string ChangeExtendedAwayGreeting { get; set; }
    [XmlElement(ElementName = "composeMessage", IsNullable = true)]
    public string ComposeMessage { get; set; }
    [XmlElement(ElementName = "deleteAllMessages", IsNullable = true)]
    public string DeleteAllMessages { get; set; }
    [XmlElement(ElementName = "passcode", IsNullable = true)]
    public string Passcode { get; set; }
    [XmlElement(ElementName = "personalizedName", IsNullable = true)]
    public string PersonalizedName { get; set; }
    [XmlElement(ElementName = "messageDeposit", IsNullable = true)]
    public string MessageDeposit { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = true)]
    public string RepeatMenu { get; set; }
 }
}
