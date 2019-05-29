using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "deviceType", IsNullable = false)]
    public string DeviceType { get; set; }
    [XmlElement(ElementName = "countOnlyResetSupportedDevice", IsNullable = false)]
    public bool CountOnlyResetSupportedDevice { get; set; }
    [XmlElement(ElementName = "allowUnmanagedDeviceType", IsNullable = false)]
    public bool AllowUnmanagedDeviceType { get; set; }
 }
}
