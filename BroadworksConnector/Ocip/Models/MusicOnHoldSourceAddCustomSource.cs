using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldSourceAddCustomSource 
{
    [XmlElement(ElementName = "audioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource AudioFile { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource VideoFile { get; set; }
 }
}
