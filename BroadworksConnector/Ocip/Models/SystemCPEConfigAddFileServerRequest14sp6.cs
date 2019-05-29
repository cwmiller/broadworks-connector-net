using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCPEConfigAddFileServerRequest14sp6 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "deviceType", IsNullable = false)]
    public string DeviceType { get; set; }
    [XmlElement(ElementName = "fileRepositoryName", IsNullable = false)]
    public string FileRepositoryName { get; set; }
    [XmlElement(ElementName = "cpeFileDirectory", IsNullable = false)]
    public string CpeFileDirectory { get; set; }
    [XmlElement(ElementName = "extendedCaptureFileRepositoryName", IsNullable = false)]
    public string ExtendedCaptureFileRepositoryName { get; set; }
 }
}
