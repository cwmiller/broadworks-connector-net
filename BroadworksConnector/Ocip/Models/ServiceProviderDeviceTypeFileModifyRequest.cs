using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDeviceTypeFileModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode _fileSource;

    [XmlElement(ElementName = "fileSource", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode FileSource {
        get => _fileSource;
        set {
            FileSourceSpecified = true;
            _fileSource = value;
        }
    }

    [XmlIgnore]
    public bool FileSourceSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.FileResource _uploadFile;

    [XmlElement(ElementName = "uploadFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.FileResource UploadFile {
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
