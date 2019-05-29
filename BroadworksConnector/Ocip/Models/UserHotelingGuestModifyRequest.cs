using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserHotelingGuestModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "enableAssociationLimit", IsNullable = false)]
    public bool EnableAssociationLimit { get; set; }
    [XmlElement(ElementName = "associationLimitHours", IsNullable = false)]
    public int AssociationLimitHours { get; set; }
    [XmlElement(ElementName = "hostUserId", IsNullable = true)]
    public string HostUserId { get; set; }
 }
}
