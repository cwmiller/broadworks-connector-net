using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeFileAddRequest20 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "deviceType", IsNullable = false)]
    public string DeviceType { get; set; }
    [XmlElement(ElementName = "fileFormat", IsNullable = false)]
    public string FileFormat { get; set; }
    [XmlElement(ElementName = "remoteFileFormat", IsNullable = false)]
    public string RemoteFileFormat { get; set; }
    [XmlElement(ElementName = "fileCategory", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementFileCategory FileCategory { get; set; }
    [XmlElement(ElementName = "fileCustomization", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementFileCustomization FileCustomization { get; set; }
    [XmlElement(ElementName = "fileSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceTypeFileEnhancedConfigurationMode FileSource { get; set; }
    [XmlElement(ElementName = "uploadFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.FileResource UploadFile { get; set; }
    [XmlElement(ElementName = "useHttpDigestAuthentication", IsNullable = false)]
    public bool UseHttpDigestAuthentication { get; set; }
    [XmlElement(ElementName = "macBasedFileAuthentication", IsNullable = false)]
    public bool MacBasedFileAuthentication { get; set; }
    [XmlElement(ElementName = "userNamePasswordFileAuthentication", IsNullable = false)]
    public bool UserNamePasswordFileAuthentication { get; set; }
    [XmlElement(ElementName = "macInNonRequestURI", IsNullable = false)]
    public bool MacInNonRequestURI { get; set; }
    [XmlElement(ElementName = "macFormatInNonRequestURI", IsNullable = false)]
    public string MacFormatInNonRequestURI { get; set; }
    [XmlElement(ElementName = "allowHttp", IsNullable = false)]
    public bool AllowHttp { get; set; }
    [XmlElement(ElementName = "allowHttps", IsNullable = false)]
    public bool AllowHttps { get; set; }
    [XmlElement(ElementName = "allowTftp", IsNullable = false)]
    public bool AllowTftp { get; set; }
    [XmlElement(ElementName = "enableCaching", IsNullable = false)]
    public bool EnableCaching { get; set; }
    [XmlElement(ElementName = "allowUploadFromDevice", IsNullable = false)]
    public bool AllowUploadFromDevice { get; set; }
    [XmlElement(ElementName = "defaultExtendedFileCaptureMode", IsNullable = false)]
    public bool DefaultExtendedFileCaptureMode { get; set; }
 }
}
