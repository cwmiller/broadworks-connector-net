using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SelectDistributionListMenuKeys 
{
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenuOrFinishEnteringDistributionListNumber", IsNullable = false)]
    public string RepeatMenuOrFinishEnteringDistributionListNumber { get; set; }
 }
}
