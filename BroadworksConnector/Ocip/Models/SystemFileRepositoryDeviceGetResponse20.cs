using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemFileRepositoryDeviceGetResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _rootDirectory;

    [XmlElement(ElementName = "rootDirectory", IsNullable = false, Namespace = "")]
    public string RootDirectory {
        get => _rootDirectory;
        set {
            RootDirectorySpecified = true;
            _rootDirectory = value;
        }
    }

    [XmlIgnore]
    public bool RootDirectorySpecified { get; set; }
    private int _port;

    [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
    public int Port {
        get => _port;
        set {
            PortSpecified = true;
            _port = value;
        }
    }

    [XmlIgnore]
    public bool PortSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.FileRepositoryProtocolWebDAV20 _protocolWebDAV;

    [XmlElement(ElementName = "protocolWebDAV", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.FileRepositoryProtocolWebDAV20 ProtocolWebDAV {
        get => _protocolWebDAV;
        set {
            ProtocolWebDAVSpecified = true;
            _protocolWebDAV = value;
        }
    }

    [XmlIgnore]
    public bool ProtocolWebDAVSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.FileRepositoryProtocolFTP16 _protocolFTP;

    [XmlElement(ElementName = "protocolFTP", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.FileRepositoryProtocolFTP16 ProtocolFTP {
        get => _protocolFTP;
        set {
            ProtocolFTPSpecified = true;
            _protocolFTP = value;
        }
    }

    [XmlIgnore]
    public bool ProtocolFTPSpecified { get; set; }
}
}
