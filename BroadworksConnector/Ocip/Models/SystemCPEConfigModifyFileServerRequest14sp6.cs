using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCPEConfigModifyFileServerRequest14sp6 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _deviceType;

    [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
    public string DeviceType {
        get => _deviceType;
        set {
            DeviceTypeSpecified = true;
            _deviceType = value;
        }
    }

    [XmlIgnore]
    public bool DeviceTypeSpecified { get; set; }
    private string _fileRepositoryName;

    [XmlElement(ElementName = "fileRepositoryName", IsNullable = false, Namespace = "")]
    public string FileRepositoryName {
        get => _fileRepositoryName;
        set {
            FileRepositoryNameSpecified = true;
            _fileRepositoryName = value;
        }
    }

    [XmlIgnore]
    public bool FileRepositoryNameSpecified { get; set; }
    private string _cpeFileDirectory;

    [XmlElement(ElementName = "cpeFileDirectory", IsNullable = true, Namespace = "")]
    public string CpeFileDirectory {
        get => _cpeFileDirectory;
        set {
            CpeFileDirectorySpecified = true;
            _cpeFileDirectory = value;
        }
    }

    [XmlIgnore]
    public bool CpeFileDirectorySpecified { get; set; }
    private string _extendedCaptureFileRepositoryName;

    [XmlElement(ElementName = "extendedCaptureFileRepositoryName", IsNullable = true, Namespace = "")]
    public string ExtendedCaptureFileRepositoryName {
        get => _extendedCaptureFileRepositoryName;
        set {
            ExtendedCaptureFileRepositoryNameSpecified = true;
            _extendedCaptureFileRepositoryName = value;
        }
    }

    [XmlIgnore]
    public bool ExtendedCaptureFileRepositoryNameSpecified { get; set; }
}
}
