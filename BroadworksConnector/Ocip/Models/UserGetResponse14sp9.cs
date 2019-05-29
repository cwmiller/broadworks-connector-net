using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserGetResponse14sp9 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
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
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "extension", IsNullable = false)]
    public string Extension { get; set; }
    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = false)]
    public string CallingLineIdPhoneNumber { get; set; }
    [XmlElement(ElementName = "department", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DepartmentKey Department { get; set; }
    [XmlElement(ElementName = "departmentFullPath", IsNullable = false)]
    public string DepartmentFullPath { get; set; }
    [XmlElement(ElementName = "language", IsNullable = false)]
    public string Language { get; set; }
    [XmlElement(ElementName = "timeZone", IsNullable = false)]
    public string TimeZone { get; set; }
    [XmlElement(ElementName = "timeZoneDisplayName", IsNullable = false)]
    public string TimeZoneDisplayName { get; set; }
    [XmlElement(ElementName = "defaultAlias", IsNullable = false)]
    public string DefaultAlias { get; set; }
    [XmlElement(ElementName = "alias", IsNullable = false)]
    public List<string> Alias { get; set; }
    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointRead14 AccessDeviceEndpoint { get; set; }
    [XmlElement(ElementName = "trunkAddressing", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkAddressingRead TrunkAddressing { get; set; }
    [XmlElement(ElementName = "title", IsNullable = false)]
    public string Title { get; set; }
    [XmlElement(ElementName = "pagerPhoneNumber", IsNullable = false)]
    public string PagerPhoneNumber { get; set; }
    [XmlElement(ElementName = "mobilePhoneNumber", IsNullable = false)]
    public string MobilePhoneNumber { get; set; }
    [XmlElement(ElementName = "emailAddress", IsNullable = false)]
    public string EmailAddress { get; set; }
    [XmlElement(ElementName = "yahooId", IsNullable = false)]
    public string YahooId { get; set; }
    [XmlElement(ElementName = "addressLocation", IsNullable = false)]
    public string AddressLocation { get; set; }
    [XmlElement(ElementName = "address", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.StreetAddress Address { get; set; }
    [XmlElement(ElementName = "countryCode", IsNullable = false)]
    public string CountryCode { get; set; }
    [XmlElement(ElementName = "nationalPrefix", IsNullable = false)]
    public string NationalPrefix { get; set; }
 }
}
