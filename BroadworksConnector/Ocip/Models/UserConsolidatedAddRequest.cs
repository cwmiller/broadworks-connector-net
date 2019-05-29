using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserConsolidatedAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "groupProperties", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ConsolidatedGroupProperties GroupProperties { get; set; }
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "addPhoneNumberToGroup", IsNullable = false)]
    public bool AddPhoneNumberToGroup { get; set; }
    [XmlElement(ElementName = "lastName", IsNullable = false)]
    public string LastName { get; set; }
    [XmlElement(ElementName = "firstName", IsNullable = false)]
    public string FirstName { get; set; }
    [XmlElement(ElementName = "callingLineIdLastName", IsNullable = false)]
    public string CallingLineIdLastName { get; set; }
    [XmlElement(ElementName = "callingLineIdFirstName", IsNullable = false)]
    public string CallingLineIdFirstName { get; set; }
    [XmlElement(ElementName = "nameDialingName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NameDialingName NameDialingName { get; set; }
    [XmlElement(ElementName = "hiraganaLastName", IsNullable = false)]
    public string HiraganaLastName { get; set; }
    [XmlElement(ElementName = "hiraganaFirstName", IsNullable = false)]
    public string HiraganaFirstName { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "alternateUserId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AlternateUserIdEntry> AlternateUserId { get; set; }
    [XmlElement(ElementName = "extension", IsNullable = false)]
    public string Extension { get; set; }
    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = false)]
    public string CallingLineIdPhoneNumber { get; set; }
    [XmlElement(ElementName = "password", IsNullable = false)]
    public string Password { get; set; }
    [XmlElement(ElementName = "passcode", IsNullable = false)]
    public string Passcode { get; set; }
    [XmlElement(ElementName = "department", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DepartmentKey Department { get; set; }
    [XmlElement(ElementName = "language", IsNullable = false)]
    public string Language { get; set; }
    [XmlElement(ElementName = "timeZone", IsNullable = false)]
    public string TimeZone { get; set; }
    [XmlElement(ElementName = "alias", IsNullable = false)]
    public List<string> Alias { get; set; }
    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ConsolidatedAccessDeviceMultipleIdentityEndpointAndContactAdd AccessDeviceEndpoint { get; set; }
    [XmlElement(ElementName = "trunkAddressing", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkAddressingMultipleContactAdd TrunkAddressing { get; set; }
    [XmlElement(ElementName = "sharedCallAppearanceAccessDeviceEndpoint", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint> SharedCallAppearanceAccessDeviceEndpoint { get; set; }
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
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
    [XmlElement(ElementName = "userService", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> UserService { get; set; }
    [XmlElement(ElementName = "servicePack", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ConsolidatedServicePackAssignment> ServicePack { get; set; }
    [XmlElement(ElementName = "thirdPartyVoiceMailServerSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ThirdPartyVoiceMailSupportServerSelection ThirdPartyVoiceMailServerSelection { get; set; }
    [XmlElement(ElementName = "thirdPartyVoiceMailServerUserServer", IsNullable = true)]
    public string ThirdPartyVoiceMailServerUserServer { get; set; }
    [XmlElement(ElementName = "thirdPartyVoiceMailServerMailboxIdType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ThirdPartyVoiceMailSupportMailboxIdType ThirdPartyVoiceMailServerMailboxIdType { get; set; }
    [XmlElement(ElementName = "thirdPartyVoiceMailMailboxURL", IsNullable = true)]
    public string ThirdPartyVoiceMailMailboxURL { get; set; }
    [XmlElement(ElementName = "sipAuthenticationData", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SIPAuthenticationUserNamePassword SipAuthenticationData { get; set; }
 }
}
