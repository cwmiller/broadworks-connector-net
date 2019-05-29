using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19MessageDepositMenuKeys 
{
    [XmlElement(ElementName = "enableMessageDeposit", IsNullable = false)]
    public string EnableMessageDeposit { get; set; }
    [XmlElement(ElementName = "disableMessageDeposit", IsNullable = false)]
    public string DisableMessageDeposit { get; set; }
    [XmlElement(ElementName = "listenToMessageDepositStatus", IsNullable = false)]
    public string ListenToMessageDepositStatus { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = false)]
    public string RepeatMenu { get; set; }
 }
}
