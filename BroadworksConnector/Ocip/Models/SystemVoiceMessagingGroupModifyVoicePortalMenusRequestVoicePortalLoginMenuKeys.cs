using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestVoicePortalLoginMenuKeys 
{
    [XmlElement(ElementName = "accessUsingOtherMailboxId", IsNullable = true)]
    public string AccessUsingOtherMailboxId { get; set; }
 }
}
