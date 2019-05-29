using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserModifyRequest16 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "lastName", IsNullable = false)]
    public string LastName { get; set; }
    [XmlElement(ElementName = "firstName", IsNullable = false)]
    public string FirstName { get; set; }
    [XmlElement(ElementName = "callingLineIdLastName", IsNullable = false)]
    public string CallingLineIdLastName { get; set; }
    [XmlElement(ElementName = "callingLineIdFirstName", IsNullable = false)]
    public string CallingLineIdFirstName { get; set; }
    [XmlElement(ElementName = "hiraganaLastName", IsNullable = false)]
    public string HiraganaLastName { get; set; }
    [XmlElement(ElementName = "hiraganaFirstName", IsNullable = false)]
    public string HiraganaFirstName { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = true)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "extension", IsNullable = true)]
    public string Extension { get; set; }
    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = true)]
    public string CallingLineIdPhoneNumber { get; set; }
    [XmlElement(ElementName = "oldPassword", IsNullable = false)]
    public string OldPassword { get; set; }
    [XmlElement(ElementName = "newPassword", IsNullable = true)]
    public string NewPassword { get; set; }
    [XmlElement(ElementName = "department", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.DepartmentKey Department { get; set; }
    [XmlElement(ElementName = "language", IsNullable = false)]
    public string Language { get; set; }
    [XmlElement(ElementName = "timeZone", IsNullable = false)]
    public string TimeZone { get; set; }
    [XmlElement(ElementName = "sipAliasList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementSIPAliasList SipAliasList { get; set; }
    [XmlElement(ElementName = "endpoint", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.UserModifyRequest16Endpoint Endpoint { get; set; }
    [XmlElement(ElementName = "title", IsNullable = true)]
    public string Title { get; set; }
    [XmlElement(ElementName = "pagerPhoneNumber", IsNullable = true)]
    public string PagerPhoneNumber { get; set; }
    [XmlElement(ElementName = "mobilePhoneNumber", IsNullable = true)]
    public string MobilePhoneNumber { get; set; }
    [XmlElement(ElementName = "emailAddress", IsNullable = true)]
    public string EmailAddress { get; set; }
    [XmlElement(ElementName = "yahooId", IsNullable = true)]
    public string YahooId { get; set; }
    [XmlElement(ElementName = "addressLocation", IsNullable = true)]
    public string AddressLocation { get; set; }
    [XmlElement(ElementName = "address", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.StreetAddress Address { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
    [XmlElement(ElementName = "officeZoneName", IsNullable = false)]
    public string OfficeZoneName { get; set; }
    [XmlElement(ElementName = "primaryZoneName", IsNullable = false)]
    public string PrimaryZoneName { get; set; }
 }
}
