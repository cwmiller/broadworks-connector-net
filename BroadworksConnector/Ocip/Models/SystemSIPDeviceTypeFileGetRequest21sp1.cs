using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeFileGetRequest21sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
}
}
