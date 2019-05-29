using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMaliciousCallTraceGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "playMCTWarningAnnouncement", IsNullable = false)]
    public bool PlayMCTWarningAnnouncement { get; set; }
    [XmlElement(ElementName = "userTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UserTable { get; set; }
 }
}
