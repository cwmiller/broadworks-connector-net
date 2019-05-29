using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class IPAddressRange 
{
    [XmlElement(ElementName = "minIpAddress", IsNullable = false)]
    public string MinIpAddress { get; set; }
    [XmlElement(ElementName = "maxIpAddress", IsNullable = false)]
    public string MaxIpAddress { get; set; }
 }
}
