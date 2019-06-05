using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceFileApplyExtendedCaptureToAllDeviceProfilesRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _extendedCaptureOnUploadFromDevice;

    [XmlElement(ElementName = "extendedCaptureOnUploadFromDevice", IsNullable = false, Namespace = "")]
    public bool ExtendedCaptureOnUploadFromDevice {
        get => _extendedCaptureOnUploadFromDevice;
        set {
            ExtendedCaptureOnUploadFromDeviceSpecified = true;
            _extendedCaptureOnUploadFromDevice = value;
        }
    }

    [XmlIgnore]
    public bool ExtendedCaptureOnUploadFromDeviceSpecified { get; set; }
}
}
