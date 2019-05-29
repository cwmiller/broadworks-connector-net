using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestPlayGreetingMenuKeys 
{
    [XmlElement(ElementName = "skipBackward", IsNullable = true)]
    public string SkipBackward { get; set; }
    [XmlElement(ElementName = "pauseOrResume", IsNullable = true)]
    public string PauseOrResume { get; set; }
    [XmlElement(ElementName = "skipForward", IsNullable = true)]
    public string SkipForward { get; set; }
    [XmlElement(ElementName = "jumpToBegin", IsNullable = true)]
    public string JumpToBegin { get; set; }
    [XmlElement(ElementName = "jumpToEnd", IsNullable = true)]
    public string JumpToEnd { get; set; }
 }
}
