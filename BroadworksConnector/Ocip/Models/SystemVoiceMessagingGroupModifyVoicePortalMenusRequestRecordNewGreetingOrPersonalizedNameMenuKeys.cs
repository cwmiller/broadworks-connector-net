using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestRecordNewGreetingOrPersonalizedNameMenuKeys 
{
    [XmlElement(ElementName = "endRecording", IsNullable = false)]
    public string EndRecording { get; set; }
 }
}
