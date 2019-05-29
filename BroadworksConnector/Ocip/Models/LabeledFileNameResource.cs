using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class LabeledFileNameResource 
{
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "mediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType MediaType { get; set; }
    [XmlElement(ElementName = "sourceFileName", IsNullable = false)]
    public string SourceFileName { get; set; }
 }
}
