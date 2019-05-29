using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetDNISAnnouncementRequest17sp4 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "dnisKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DNISKey DnisKey { get; set; }
 }
}
