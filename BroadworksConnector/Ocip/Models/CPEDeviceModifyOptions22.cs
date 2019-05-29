using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CPEDeviceModifyOptions22 
{
    [XmlElement(ElementName = "enableMonitoring", IsNullable = false)]
    public bool EnableMonitoring { get; set; }
    [XmlElement(ElementName = "deviceManagementDeviceTypeOptions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementDeviceTypeModifyOptions22 DeviceManagementDeviceTypeOptions { get; set; }
 }
}
