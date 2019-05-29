using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserHotelingHostGetResponse14 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "associationLimitHours", IsNullable = false)]
    public int AssociationLimitHours { get; set; }
    [XmlElement(ElementName = "accessLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HotelingHostAccessLevel AccessLevel { get; set; }
    [XmlElement(ElementName = "guestLastName", IsNullable = false)]
    public string GuestLastName { get; set; }
    [XmlElement(ElementName = "guestFirstName", IsNullable = false)]
    public string GuestFirstName { get; set; }
    [XmlElement(ElementName = "guestPhoneNumber", IsNullable = false)]
    public string GuestPhoneNumber { get; set; }
    [XmlElement(ElementName = "guestExtension", IsNullable = false)]
    public string GuestExtension { get; set; }
    [XmlElement(ElementName = "guestLocationDialingCode", IsNullable = false)]
    public string GuestLocationDialingCode { get; set; }
    [XmlElement(ElementName = "guestAssociationDateTime", IsNullable = false)]
    public string GuestAssociationDateTime { get; set; }
 }
}
