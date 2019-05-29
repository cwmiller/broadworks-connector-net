using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class FileResource 
{
    [XmlElement(ElementName = "sourceFileName", IsNullable = false)]
    public string SourceFileName { get; set; }
    [XmlElement(ElementName = "fileContent", IsNullable = false)]
    public string FileContent { get; set; }
 }
}
