using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCPEConfigModifyFileServerRequest14sp6 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "deviceType", IsNullable = false)]
    public string DeviceType { get; set; }
    [XmlElement(ElementName = "fileRepositoryName", IsNullable = false)]
    public string FileRepositoryName { get; set; }
    [XmlElement(ElementName = "cpeFileDirectory", IsNullable = true)]
    public string CpeFileDirectory { get; set; }
    [XmlElement(ElementName = "extendedCaptureFileRepositoryName", IsNullable = true)]
    public string ExtendedCaptureFileRepositoryName { get; set; }
 }
}
