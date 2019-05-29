using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19AnnouncementMenuKeys 
{
    [XmlElement(ElementName = "recordAudio", IsNullable = true)]
    public string RecordAudio { get; set; }
    [XmlElement(ElementName = "recordAudioVideo", IsNullable = true)]
    public string RecordAudioVideo { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = true)]
    public string RepeatMenu { get; set; }
 }
}
