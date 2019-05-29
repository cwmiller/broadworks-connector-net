using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldUserSourceRead20CustomSource 
{
    [XmlElement(ElementName = "audioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey AudioFile { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey VideoFile { get; set; }
 }
}
