using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCPEConfigRebuildConfigFileRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "deviceType", IsNullable = false)]
    public string DeviceType { get; set; }
    [XmlElement(ElementName = "rebuildType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CPEDeviceConfigRebuildType RebuildType { get; set; }
    [XmlElement(ElementName = "force", IsNullable = false)]
    public bool Force { get; set; }
 }
}
