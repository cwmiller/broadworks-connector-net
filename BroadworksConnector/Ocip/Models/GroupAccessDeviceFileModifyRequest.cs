using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccessDeviceFileModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "deviceName", IsNullable = false)]
    public string DeviceName { get; set; }
    [XmlElement(ElementName = "fileType", IsNullable = false)]
    public string FileType { get; set; }
    [XmlElement(ElementName = "fileSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode FileSource { get; set; }
    [XmlElement(ElementName = "uploadFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.FileResource UploadFile { get; set; }
 }
}
