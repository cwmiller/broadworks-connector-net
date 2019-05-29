using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CPEDeviceModifyOptions16 
{
    [XmlElement(ElementName = "enableMonitoring", IsNullable = false)]
    public bool EnableMonitoring { get; set; }
    [XmlElement(ElementName = "resetEvent", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.CPEDeviceResetEventType? ResetEvent { get; set; }
    [XmlElement(ElementName = "deviceManagementDeviceTypeOptions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementDeviceTypeModifyOptions16 DeviceManagementDeviceTypeOptions { get; set; }
 }
}
