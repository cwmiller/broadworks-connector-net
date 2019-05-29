using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1VoicePortalCallingMenuKeys 
{
    [XmlElement(ElementName = "endCurrentCallAndGoBackToPreviousMenu", IsNullable = false)]
    public string EndCurrentCallAndGoBackToPreviousMenu { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
 }
}
