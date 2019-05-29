using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19ReviewSelectedDistributionListMenuKeys 
{
    [XmlElement(ElementName = "interruptPlaybackAndReturnToPreviousMenu", IsNullable = false)]
    public string InterruptPlaybackAndReturnToPreviousMenu { get; set; }
 }
}
