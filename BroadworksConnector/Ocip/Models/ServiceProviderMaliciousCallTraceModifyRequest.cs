using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderMaliciousCallTraceModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "useSystemPlayMCTWarningAnnouncement", IsNullable = false)]
    public bool UseSystemPlayMCTWarningAnnouncement { get; set; }
    [XmlElement(ElementName = "playMCTWarningAnnouncement", IsNullable = false)]
    public bool PlayMCTWarningAnnouncement { get; set; }
 }
}
