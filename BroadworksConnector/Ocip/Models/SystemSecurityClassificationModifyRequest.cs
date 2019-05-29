using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSecurityClassificationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "meetMeAnncThreshold", IsNullable = false)]
    public int MeetMeAnncThreshold { get; set; }
    [XmlElement(ElementName = "playTrunkUserSecurityClassificationAnnouncement", IsNullable = false)]
    public bool PlayTrunkUserSecurityClassificationAnnouncement { get; set; }
    [XmlElement(ElementName = "securityClassificationName", IsNullable = false)]
    public List<string> SecurityClassificationName { get; set; }
 }
}
