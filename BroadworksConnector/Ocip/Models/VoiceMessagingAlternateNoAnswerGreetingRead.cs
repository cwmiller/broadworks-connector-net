using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class VoiceMessagingAlternateNoAnswerGreetingRead 
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "audioFile", IsNullable = false)]
    public string AudioFile { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = false)]
    public string VideoFile { get; set; }
 }
}
