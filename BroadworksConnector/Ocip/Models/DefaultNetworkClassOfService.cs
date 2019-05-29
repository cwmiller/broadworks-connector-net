using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class DefaultNetworkClassOfService 
{
    [XmlElement(ElementName = "useExisting", IsNullable = false)]
    public bool UseExisting { get; set; }
    [XmlElement(ElementName = "networkClassOfServiceName", IsNullable = false)]
    public string NetworkClassOfServiceName { get; set; }
 }
}
