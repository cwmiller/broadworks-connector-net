using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class NetworkClassOfServiceCommunicationBarringProfile 
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "isPrimary", IsNullable = false)]
    public bool IsPrimary { get; set; }
 }
}
