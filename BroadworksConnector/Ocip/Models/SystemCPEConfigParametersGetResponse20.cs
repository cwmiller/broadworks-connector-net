using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCPEConfigParametersGetResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableIPDeviceManagement", IsNullable = false)]
    public bool EnableIPDeviceManagement { get; set; }
    [XmlElement(ElementName = "ftpConnectTimeoutSeconds", IsNullable = false)]
    public int FtpConnectTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "ftpFileTransferTimeoutSeconds", IsNullable = false)]
    public int FtpFileTransferTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "pauseBetweenFileRebuildMilliseconds", IsNullable = false)]
    public int PauseBetweenFileRebuildMilliseconds { get; set; }
    [XmlElement(ElementName = "maxBusyTimeMinutes", IsNullable = false)]
    public int MaxBusyTimeMinutes { get; set; }
    [XmlElement(ElementName = "deviceAccessAppServerClusterName", IsNullable = false)]
    public string DeviceAccessAppServerClusterName { get; set; }
 }
}
