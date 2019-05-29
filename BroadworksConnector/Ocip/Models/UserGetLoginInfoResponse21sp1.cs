using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserGetLoginInfoResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "loginType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LoginType LoginType { get; set; }
    [XmlElement(ElementName = "locale", IsNullable = false)]
    public string Locale { get; set; }
    [XmlElement(ElementName = "encoding", IsNullable = false)]
    public string Encoding { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "isEnterprise", IsNullable = false)]
    public bool IsEnterprise { get; set; }
    [XmlElement(ElementName = "passwordExpiresDays", IsNullable = false)]
    public int PasswordExpiresDays { get; set; }
    [XmlElement(ElementName = "lastName", IsNullable = false)]
    public string LastName { get; set; }
    [XmlElement(ElementName = "firstName", IsNullable = false)]
    public string FirstName { get; set; }
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "tokenRevocationTime", IsNullable = false)]
    public string TokenRevocationTime { get; set; }
 }
}
