using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAccessDeviceFileModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _deviceName;

    [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
    public string DeviceName {
        get => _deviceName;
        set {
            DeviceNameSpecified = true;
            _deviceName = value;
        }
    }

    [XmlIgnore]
    public bool DeviceNameSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode _fileSource;

    [XmlElement(ElementName = "fileSource", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode FileSource {
        get => _fileSource;
        set {
            FileSourceSpecified = true;
            _fileSource = value;
        }
    }

    [XmlIgnore]
    public bool FileSourceSpecified { get; set; }
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