using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAnnouncementFileDeleteListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "announcementFileKey", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AnnouncementFileKey> AnnouncementFileKey { get; set; }
 }
}
