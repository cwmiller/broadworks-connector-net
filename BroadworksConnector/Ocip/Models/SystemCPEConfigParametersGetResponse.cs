using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCPEConfigParametersGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enableIPDeviceManagement;

    [XmlElement(ElementName = "enableIPDeviceManagement", IsNullable = false, Namespace = "")]
    public bool EnableIPDeviceManagement {
        get => _enableIPDeviceManagement;
        set {
            EnableIPDeviceManagementSpecified = true;
            _enableIPDeviceManagement = value;
        }
    }

    [XmlIgnore]
    public bool EnableIPDeviceManagementSpecified { get; set; }
    private int _ftpConnectTimeoutSeconds;

    [XmlElement(ElementName = "ftpConnectTimeoutSeconds", IsNullable = false, Namespace = "")]
    public int FtpConnectTimeoutSeconds {
        get => _ftpConnectTimeoutSeconds;
        set {
            FtpConnectTimeoutSecondsSpecified = true;
            _ftpConnectTimeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool FtpConnectTimeoutSecondsSpecified { get; set; }
    private int _ftpFileTransferTimeoutSeconds;

    [XmlElement(ElementName = "ftpFileTransferTimeoutSeconds", IsNullable = false, Namespace = "")]
    public int FtpFileTransferTimeoutSeconds {
        get => _ftpFileTransferTimeoutSeconds;
        set {
            FtpFileTransferTimeoutSecondsSpecified = true;
            _ftpFileTransferTimeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool FtpFileTransferTimeoutSecondsSpecified { get; set; }
}
}
