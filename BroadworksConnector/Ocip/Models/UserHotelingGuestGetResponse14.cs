using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserHotelingGuestGetResponse14 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "associationLimitHours", IsNullable = false)]
    public int AssociationLimitHours { get; set; }
    [XmlElement(ElementName = "hostUserId", IsNullable = false)]
    public string HostUserId { get; set; }
    [XmlElement(ElementName = "hostLastName", IsNullable = false)]
    public string HostLastName { get; set; }
    [XmlElement(ElementName = "hostFirstName", IsNullable = false)]
    public string HostFirstName { get; set; }
    [XmlElement(ElementName = "hostAssociationDateTime", IsNullable = false)]
    public string HostAssociationDateTime { get; set; }
 }
}
