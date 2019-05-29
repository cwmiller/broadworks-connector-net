using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldSourceRead22LabeledCustomSourceMediaFiles 
{
    [XmlElement(ElementName = "audioFileDescription", IsNullable = false)]
    public string AudioFileDescription { get; set; }
    [XmlElement(ElementName = "audioMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType AudioMediaType { get; set; }
    [XmlElement(ElementName = "videoFileDescription", IsNullable = false)]
    public string VideoFileDescription { get; set; }
    [XmlElement(ElementName = "videoMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType VideoMediaType { get; set; }
 }
}
