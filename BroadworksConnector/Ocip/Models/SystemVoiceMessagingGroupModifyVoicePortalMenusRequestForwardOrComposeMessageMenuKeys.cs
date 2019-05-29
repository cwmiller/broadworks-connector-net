using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestForwardOrComposeMessageMenuKeys 
{
    [XmlElement(ElementName = "sendToPerson", IsNullable = true)]
    public string SendToPerson { get; set; }
    [XmlElement(ElementName = "sendToAllGroupMembers", IsNullable = true)]
    public string SendToAllGroupMembers { get; set; }
    [XmlElement(ElementName = "sendToDistributionList", IsNullable = true)]
    public string SendToDistributionList { get; set; }
    [XmlElement(ElementName = "changeCurrentIntroductionOrMessage", IsNullable = true)]
    public string ChangeCurrentIntroductionOrMessage { get; set; }
    [XmlElement(ElementName = "listenToCurrentIntroductionOrMessage", IsNullable = true)]
    public string ListenToCurrentIntroductionOrMessage { get; set; }
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
