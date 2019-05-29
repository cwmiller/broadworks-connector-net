using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class VoiceMessagingAlternateNoAnswerGreetingModify20 
{
    [XmlElement(ElementName = "name", IsNullable = true)]
    public string Name { get; set; }
    [XmlElement(ElementName = "audioFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey AudioFile { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey VideoFile { get; set; }
 }
}
