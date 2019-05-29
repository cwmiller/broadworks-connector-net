using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallRecordingGetPlatformListResponse20sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "systemDefault", IsNullable = false)]
    public string SystemDefault { get; set; }
    [XmlElement(ElementName = "callRecordingPlatformTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CallRecordingPlatformTable { get; set; }
 }
}
