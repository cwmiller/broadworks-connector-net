using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ForwardOrComposeMessageMenuKeys 
{
    [XmlElement(ElementName = "sendToPerson", IsNullable = false)]
    public string SendToPerson { get; set; }
    [XmlElement(ElementName = "sendToAllGroupMembers", IsNullable = false)]
    public string SendToAllGroupMembers { get; set; }
    [XmlElement(ElementName = "sendToDistributionList", IsNullable = false)]
    public string SendToDistributionList { get; set; }
    [XmlElement(ElementName = "changeCurrentIntroductionOrMessage", IsNullable = false)]
    public string ChangeCurrentIntroductionOrMessage { get; set; }
    [XmlElement(ElementName = "listenToCurrentIntroductionOrMessage", IsNullable = false)]
    public string ListenToCurrentIntroductionOrMessage { get; set; }
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
