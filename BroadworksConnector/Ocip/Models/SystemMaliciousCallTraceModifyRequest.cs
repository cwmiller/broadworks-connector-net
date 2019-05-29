using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMaliciousCallTraceModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "playMCTWarningAnnouncement", IsNullable = false)]
    public bool PlayMCTWarningAnnouncement { get; set; }
 }
}
