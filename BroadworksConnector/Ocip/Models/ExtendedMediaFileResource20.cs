using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ExtendedMediaFileResource20 
{
    [XmlElement(ElementName = "file", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey File { get; set; }
    [XmlElement(ElementName = "url", IsNullable = true)]
    public string Url { get; set; }
 }
}
