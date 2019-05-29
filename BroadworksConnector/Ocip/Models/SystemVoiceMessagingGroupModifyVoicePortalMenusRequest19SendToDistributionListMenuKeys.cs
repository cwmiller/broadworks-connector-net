using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19SendToDistributionListMenuKeys 
{
    [XmlElement(ElementName = "sendMessageToSelectedDistributionList", IsNullable = false)]
    public string SendMessageToSelectedDistributionList { get; set; }
    [XmlElement(ElementName = "selectDistributionList", IsNullable = true)]
    public string SelectDistributionList { get; set; }
    [XmlElement(ElementName = "reviewSelectedDistributionList", IsNullable = true)]
    public string ReviewSelectedDistributionList { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = true)]
    public string RepeatMenu { get; set; }
 }
}
