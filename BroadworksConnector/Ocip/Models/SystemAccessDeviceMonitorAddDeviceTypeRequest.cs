using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccessDeviceMonitorAddDeviceTypeRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "addAllDeviceTypes", IsNullable = false)]
    public bool AddAllDeviceTypes { get; set; }
    [XmlElement(ElementName = "deviceType", IsNullable = false)]
    public string DeviceType { get; set; }
 }
}
