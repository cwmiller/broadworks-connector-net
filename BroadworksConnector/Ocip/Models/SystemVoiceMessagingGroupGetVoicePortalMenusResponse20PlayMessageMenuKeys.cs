using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse20PlayMessageMenuKeys 
{
    [XmlElement(ElementName = "skipBackward", IsNullable = false)]
    public string SkipBackward { get; set; }
    [XmlElement(ElementName = "pauseOrResume", IsNullable = false)]
    public string PauseOrResume { get; set; }
    [XmlElement(ElementName = "skipForward", IsNullable = false)]
    public string SkipForward { get; set; }
    [XmlElement(ElementName = "jumpToBegin", IsNullable = false)]
    public string JumpToBegin { get; set; }
    [XmlElement(ElementName = "jumpToEnd", IsNullable = false)]
    public string JumpToEnd { get; set; }
 }
}
