using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18SendMessageToSelectedDistributionListMenuKeys 
{
    [XmlElement(ElementName = "confirmSendingToDistributionList", IsNullable = false)]
    public string ConfirmSendingToDistributionList { get; set; }
    [XmlElement(ElementName = "cancelSendingToDistributionList", IsNullable = false)]
    public string CancelSendingToDistributionList { get; set; }
 }
}
