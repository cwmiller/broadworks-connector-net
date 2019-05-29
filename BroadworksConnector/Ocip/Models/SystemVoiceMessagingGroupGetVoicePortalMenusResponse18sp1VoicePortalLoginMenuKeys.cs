using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1VoicePortalLoginMenuKeys 
{
    [XmlElement(ElementName = "accessUsingOtherMailboxId", IsNullable = false)]
    public string AccessUsingOtherMailboxId { get; set; }
 }
}
