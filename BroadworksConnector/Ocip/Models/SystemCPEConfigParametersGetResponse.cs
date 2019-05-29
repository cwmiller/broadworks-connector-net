using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCPEConfigParametersGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableIPDeviceManagement", IsNullable = false)]
    public bool EnableIPDeviceManagement { get; set; }
    [XmlElement(ElementName = "ftpConnectTimeoutSeconds", IsNullable = false)]
    public int FtpConnectTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "ftpFileTransferTimeoutSeconds", IsNullable = false)]
    public int FtpFileTransferTimeoutSeconds { get; set; }
 }
}
