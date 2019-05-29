using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldSourceModify22AnnouncementCustomSourceMediaFiles 
{
    [XmlElement(ElementName = "audioFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey AudioFile { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey VideoFile { get; set; }
 }
}
