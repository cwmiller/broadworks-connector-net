using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ExtensionRange17 
{
    [XmlElement(ElementName = "minExtension", IsNullable = false)]
    public string MinExtension { get; set; }
    [XmlElement(ElementName = "maxExtension", IsNullable = false)]
    public string MaxExtension { get; set; }
 }
}
