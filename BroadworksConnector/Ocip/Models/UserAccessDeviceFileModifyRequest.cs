using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAccessDeviceFileModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AccessDevice _accessDevice;

    [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AccessDevice AccessDevice {
        get => _accessDevice;
        set {
            AccessDeviceSpecified = true;
            _accessDevice = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceSpecified { get; set; }
    private string _fileFormat;

    [XmlElement(ElementName = "fileFormat", IsNullable = false, Namespace = "")]
    public string FileFormat {
        get => _fileFormat;
        set {
            FileFormatSpecified = true;
            _fileFormat = value;
        }
    }

    [XmlIgnore]
    public bool FileFormatSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.FileResource _uploadFile;

    [XmlElement(ElementName = "uploadFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.FileResource UploadFile {
        get => _uploadFile;
        set {
            UploadFileSpecified = true;
            _uploadFile = value;
        }
    }

    [XmlIgnore]
    public bool UploadFileSpecified { get; set; }
}
}
