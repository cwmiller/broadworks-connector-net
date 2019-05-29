using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ReplyMessageMenuKeys 
{
    [XmlElement(ElementName = "sendReplyToCaller", IsNullable = false)]
    public string SendReplyToCaller { get; set; }
    [XmlElement(ElementName = "changeCurrentReply", IsNullable = false)]
    public string ChangeCurrentReply { get; set; }
    [XmlElement(ElementName = "listenToCurrentReply", IsNullable = false)]
    public string ListenToCurrentReply { get; set; }
    [XmlElement(ElementName = "setOrClearUrgentIndicator", IsNullable = false)]
    public string SetOrClearUrgentIndicator { get; set; }
    [XmlElement(ElementName = "setOrClearConfidentialIndicator", IsNullable = false)]
    public string SetOrClearConfidentialIndicator { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = false)]
    public string RepeatMenu { get; set; }
 }
}
