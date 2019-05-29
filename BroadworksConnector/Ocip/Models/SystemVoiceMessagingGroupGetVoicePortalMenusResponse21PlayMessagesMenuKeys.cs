using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21PlayMessagesMenuKeys 
{
    [XmlElement(ElementName = "saveMessage", IsNullable = false)]
    public string SaveMessage { get; set; }
    [XmlElement(ElementName = "deleteMessage", IsNullable = false)]
    public string DeleteMessage { get; set; }
    [XmlElement(ElementName = "playMessage", IsNullable = false)]
    public string PlayMessage { get; set; }
    [XmlElement(ElementName = "previousMessage", IsNullable = false)]
    public string PreviousMessage { get; set; }
    [XmlElement(ElementName = "playEnvelope", IsNullable = false)]
    public string PlayEnvelope { get; set; }
    [XmlElement(ElementName = "nextMessage", IsNullable = false)]
    public string NextMessage { get; set; }
    [XmlElement(ElementName = "callbackCaller", IsNullable = false)]
    public string CallbackCaller { get; set; }
    [XmlElement(ElementName = "composeMessage", IsNullable = false)]
    public string ComposeMessage { get; set; }
    [XmlElement(ElementName = "replyMessage", IsNullable = false)]
    public string ReplyMessage { get; set; }
    [XmlElement(ElementName = "forwardMessage", IsNullable = false)]
    public string ForwardMessage { get; set; }
    [XmlElement(ElementName = "additionalMessageOptions", IsNullable = false)]
    public string AdditionalMessageOptions { get; set; }
    [XmlElement(ElementName = "personalizedName", IsNullable = false)]
    public string PersonalizedName { get; set; }
    [XmlElement(ElementName = "passcode", IsNullable = false)]
    public string Passcode { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = false)]
    public string RepeatMenu { get; set; }
 }
}
