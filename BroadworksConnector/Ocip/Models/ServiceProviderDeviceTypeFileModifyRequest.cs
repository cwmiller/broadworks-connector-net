using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDeviceTypeFileModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "deviceType", IsNullable = false)]
    public string DeviceType { get; set; }
    [XmlElement(ElementName = "fileFormat", IsNullable = false)]
    public string FileFormat { get; set; }
    [XmlElement(ElementName = "fileSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode FileSource { get; set; }
    [XmlElement(ElementName = "uploadFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.FileResource UploadFile { get; set; }
 }
}
