using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ExtendedFileResource 
{
    [XmlElement(ElementName = "file", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource File { get; set; }
    [XmlElement(ElementName = "url", IsNullable = true)]
    public string Url { get; set; }
 }
}
