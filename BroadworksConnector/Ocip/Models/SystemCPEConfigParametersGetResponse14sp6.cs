using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCPEConfigParametersGetResponse14sp6 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    [XmlElement(ElementName = "fileRebuildImmediate", IsNullable = false)]
    public string FileRebuildImmediate { get; set; }
    [XmlElement(ElementName = "fileRebuildDaily", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemCPEConfigParametersGetResponse14sp6FileRebuildDaily FileRebuildDaily { get; set; }
    [XmlElement(ElementName = "fileRebuildHourly", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemCPEConfigParametersGetResponse14sp6FileRebuildHourly FileRebuildHourly { get; set; }
 }
}
