using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AnnouncementMenuKeysReadEntry 
{
    [XmlElement(ElementName = "recordAudio", IsNullable = false)]
    public string RecordAudio { get; set; }
    [XmlElement(ElementName = "recordAudioVideo", IsNullable = false)]
    public string RecordAudioVideo { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = false)]
    public string RepeatMenu { get; set; }
 }
}
