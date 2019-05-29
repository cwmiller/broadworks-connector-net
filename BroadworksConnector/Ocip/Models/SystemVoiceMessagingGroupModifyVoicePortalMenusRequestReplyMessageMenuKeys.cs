using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestReplyMessageMenuKeys 
{
    [XmlElement(ElementName = "sendReplyToCaller", IsNullable = false)]
    public string SendReplyToCaller { get; set; }
    [XmlElement(ElementName = "changeCurrentReply", IsNullable = true)]
    public string ChangeCurrentReply { get; set; }
    [XmlElement(ElementName = "listenToCurrentReply", IsNullable = true)]
    public string ListenToCurrentReply { get; set; }
    [XmlElement(ElementName = "setOrClearUrgentIndicator", IsNullable = true)]
    public string SetOrClearUrgentIndicator { get; set; }
    [XmlElement(ElementName = "setOrClearConfidentialIndicator", IsNullable = true)]
    public string SetOrClearConfidentialIndicator { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = true)]
    public string RepeatMenu { get; set; }
 }
}
