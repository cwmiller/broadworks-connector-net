using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldUserSourceReadCustomSource 
{
    [XmlElement(ElementName = "audioFileDescription", IsNullable = false)]
    public string AudioFileDescription { get; set; }
    [XmlElement(ElementName = "videoFileDescription", IsNullable = false)]
    public string VideoFileDescription { get; set; }
 }
}
