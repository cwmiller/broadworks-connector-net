using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementEnterpriseDeviceList 
{
    [XmlElement(ElementName = "device", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.EnterpriseAccessDevice> Device { get; set; }
 }
}
