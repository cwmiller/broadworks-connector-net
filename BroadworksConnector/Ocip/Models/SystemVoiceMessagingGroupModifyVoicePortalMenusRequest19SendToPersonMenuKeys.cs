using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendToPersonMenuKeys 
{
    [XmlElement(ElementName = "confirmSendingMessage", IsNullable = false)]
    public string ConfirmSendingMessage { get; set; }
    [XmlElement(ElementName = "cancelSendingMessage", IsNullable = false)]
    public string CancelSendingMessage { get; set; }
    [XmlElement(ElementName = "finishEnteringNumberWhereToSendMessageTo", IsNullable = false)]
    public string FinishEnteringNumberWhereToSendMessageTo { get; set; }
    [XmlElement(ElementName = "finishForwardingOrSendingMessage", IsNullable = false)]
    public string FinishForwardingOrSendingMessage { get; set; }
 }
}
