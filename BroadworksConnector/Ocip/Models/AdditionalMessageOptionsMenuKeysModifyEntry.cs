using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AdditionalMessageOptionsMenuKeysModifyEntry 
{
    [XmlElement(ElementName = "saveMessage", IsNullable = true)]
    public string SaveMessage { get; set; }
    [XmlElement(ElementName = "deleteMessage", IsNullable = true)]
    public string DeleteMessage { get; set; }
    [XmlElement(ElementName = "playEnvelope", IsNullable = true)]
    public string PlayEnvelope { get; set; }
    [XmlElement(ElementName = "callbackCaller", IsNullable = true)]
    public string CallbackCaller { get; set; }
    [XmlElement(ElementName = "composeMessage", IsNullable = true)]
    public string ComposeMessage { get; set; }
    [XmlElement(ElementName = "replyMessage", IsNullable = true)]
    public string ReplyMessage { get; set; }
    [XmlElement(ElementName = "forwardMessage", IsNullable = true)]
    public string ForwardMessage { get; set; }
    [XmlElement(ElementName = "personalizedName", IsNullable = true)]
    public string PersonalizedName { get; set; }
    [XmlElement(ElementName = "passcode", IsNullable = true)]
    public string Passcode { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = true)]
    public string RepeatMenu { get; set; }
 }
}
