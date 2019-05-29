using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19MessageDepositMenuKeys 
{
    [XmlElement(ElementName = "enableMessageDeposit", IsNullable = true)]
    public string EnableMessageDeposit { get; set; }
    [XmlElement(ElementName = "disableMessageDeposit", IsNullable = true)]
    public string DisableMessageDeposit { get; set; }
    [XmlElement(ElementName = "listenToMessageDepositStatus", IsNullable = true)]
    public string ListenToMessageDepositStatus { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = true)]
    public string RepeatMenu { get; set; }
 }
}
