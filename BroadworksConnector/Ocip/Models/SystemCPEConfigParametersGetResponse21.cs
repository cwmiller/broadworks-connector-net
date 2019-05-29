using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCPEConfigParametersGetResponse21 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableIPDeviceManagement", IsNullable = false)]
    public bool EnableIPDeviceManagement { get; set; }
    [XmlElement(ElementName = "ftpConnectTimeoutSeconds", IsNullable = false)]
    public int FtpConnectTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "ftpFileTransferTimeoutSeconds", IsNullable = false)]
    public int FtpFileTransferTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "pauseBetweenFileRebuildMilliseconds", IsNullable = false)]
    public int PauseBetweenFileRebuildMilliseconds { get; set; }
    [XmlElement(ElementName = "deviceAccessAppServerClusterName", IsNullable = false)]
    public string DeviceAccessAppServerClusterName { get; set; }
    [XmlElement(ElementName = "minTimeBetweenResetMilliseconds", IsNullable = false)]
    public int MinTimeBetweenResetMilliseconds { get; set; }
    [XmlElement(ElementName = "alwaysPushFilesOnRebuild", IsNullable = false)]
    public bool AlwaysPushFilesOnRebuild { get; set; }
    [XmlElement(ElementName = "maxFileOperationRetryAttempts", IsNullable = false)]
    public int MaxFileOperationRetryAttempts { get; set; }
    [XmlElement(ElementName = "enableAutoRebuildConfig", IsNullable = false)]
    public bool EnableAutoRebuildConfig { get; set; }
    [XmlElement(ElementName = "eventQueueSize", IsNullable = false)]
    public int EventQueueSize { get; set; }
    [XmlElement(ElementName = "allowDeviceCredentialsRetrieval", IsNullable = false)]
    public bool AllowDeviceCredentialsRetrieval { get; set; }
 }
}
