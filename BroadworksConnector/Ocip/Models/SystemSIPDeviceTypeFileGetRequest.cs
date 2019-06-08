using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeFileGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _fileType;

    [XmlElement(ElementName = "fileType", IsNullable = false, Namespace = "")]
    public string FileType {
        get => _fileType;
        set {
            FileTypeSpecified = true;
            _fileType = value;
        }
    }

    [XmlIgnore]
    public bool FileTypeSpecified { get; set; }
}
}
