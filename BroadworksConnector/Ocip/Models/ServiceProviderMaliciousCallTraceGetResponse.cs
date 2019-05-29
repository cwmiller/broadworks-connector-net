using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderMaliciousCallTraceGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useSystemPlayMCTWarningAnnouncement", IsNullable = false)]
    public bool UseSystemPlayMCTWarningAnnouncement { get; set; }
    [XmlElement(ElementName = "playMCTWarningAnnouncement", IsNullable = false)]
    public bool PlayMCTWarningAnnouncement { get; set; }
 }
}
