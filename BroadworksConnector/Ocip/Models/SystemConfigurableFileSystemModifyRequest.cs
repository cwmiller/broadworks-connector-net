using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConfigurableFileSystemModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _mediaDirectory;

    [XmlElement(ElementName = "mediaDirectory", IsNullable = false, Namespace = "")]
    public string MediaDirectory {
        get => _mediaDirectory;
        set {
            MediaDirectorySpecified = true;
            _mediaDirectory = value;
        }
    }

    [XmlIgnore]
    public bool MediaDirectorySpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemModifyRequestProtocolFile _protocolFile;

    [XmlElement(ElementName = "protocolFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemModifyRequestProtocolFile ProtocolFile {
        get => _protocolFile;
        set {
            ProtocolFileSpecified = true;
            _protocolFile = value;
        }
    }

    [XmlIgnore]
    public bool ProtocolFileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemModifyRequestProtocolWebDAV _protocolWebDAV;

    [XmlElement(ElementName = "protocolWebDAV", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemModifyRequestProtocolWebDAV ProtocolWebDAV {
        get => _protocolWebDAV;
        set {
            ProtocolWebDAVSpecified = true;
            _protocolWebDAV = value;
        }
    }

    [XmlIgnore]
    public bool ProtocolWebDAVSpecified { get; set; }
}
}