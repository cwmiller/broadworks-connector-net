using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementDeviceList 
{
    [XmlElement(ElementName = "device", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AccessDevice> Device { get; set; }
 }
}
