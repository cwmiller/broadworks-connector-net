using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class LabeledFileResource 
{
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "sourceFileName", IsNullable = false)]
    public string SourceFileName { get; set; }
    [XmlElement(ElementName = "content", IsNullable = false)]
    public string Content { get; set; }
 }
}
