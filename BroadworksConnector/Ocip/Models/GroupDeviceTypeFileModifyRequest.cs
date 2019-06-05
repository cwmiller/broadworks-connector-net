using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDeviceTypeFileModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
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
