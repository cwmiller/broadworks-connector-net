using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AccessDevice 
{
    [XmlElement(ElementName = "deviceLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceLevel DeviceLevel { get; set; }
    [XmlElement(ElementName = "deviceName", IsNullable = false)]
    public string DeviceName { get; set; }
 }
}
