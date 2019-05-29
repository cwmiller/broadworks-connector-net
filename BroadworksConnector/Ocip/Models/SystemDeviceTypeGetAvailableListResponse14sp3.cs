using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceTypeGetAvailableListResponse14sp3 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "deviceType", IsNullable = false)]
    public List<string> DeviceType { get; set; }
    [XmlElement(ElementName = "typeInfo", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SystemDeviceTypeGetAvailableListResponse14sp3TypeInfo> TypeInfo { get; set; }
 }
}
