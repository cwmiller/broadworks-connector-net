using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAccessDeviceFileModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "accessDevice", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDevice AccessDevice { get; set; }
    [XmlElement(ElementName = "fileFormat", IsNullable = false)]
    public string FileFormat { get; set; }
    [XmlElement(ElementName = "uploadFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.FileResource UploadFile { get; set; }
 }
}
