using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserConsolidatedModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "deleteExistingDevices", IsNullable = false)]
    public bool DeleteExistingDevices { get; set; }
    [XmlElement(ElementName = "unassignPhoneNumbers", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnassignPhoneNumbersLevel UnassignPhoneNumbers { get; set; }
    [XmlElement(ElementName = "addPhoneNumberToGroup", IsNullable = false)]
    public bool AddPhoneNumberToGroup { get; set; }
    [XmlElement(ElementName = "newUserId", IsNullable = false)]
    public string NewUserId { get; set; }
    [XmlElement(ElementName = "lastName", IsNullable = false)]
    public string LastName { get; set; }
    [XmlElement(ElementName = "firstName", IsNullable = false)]
    public string FirstName { get; set; }
    [XmlElement(ElementName = "callingLineIdLastName", IsNullable = false)]
    public string CallingLineIdLastName { get; set; }
    [XmlElement(ElementName = "callingLineIdFirstName", IsNullable = false)]
    public string CallingLineIdFirstName { get; set; }
    [XmlElement(ElementName = "nameDialingName", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.NameDialingName NameDialingName { get; set; }
    [XmlElement(ElementName = "hiraganaLastName", IsNullable = false)]
    public string HiraganaLastName { get; set; }
    [XmlElement(ElementName = "hiraganaFirstName", IsNullable = false)]
    public string HiraganaFirstName { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = true)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "alternateUserIdList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementAlternateUserIdEntryList AlternateUserIdList { get; set; }
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
    public BroadworksConnector.Ocip.Models.UserConsolidatedModifyRequestEndpoint Endpoint { get; set; }
    [XmlElement(ElementName = "sharedCallAppearanceAccessDeviceEndpointList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointList SharedCallAppearanceAccessDeviceEndpointList { get; set; }
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
    [XmlElement(ElementName = "userServiceList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementConsolidatedUserServiceAssignmentList UserServiceList { get; set; }
    [XmlElement(ElementName = "servicePackList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementConsolidatedServicePackAssignmentList ServicePackList { get; set; }
    [XmlElement(ElementName = "thirdPartyVoiceMailServerSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ThirdPartyVoiceMailSupportServerSelection ThirdPartyVoiceMailServerSelection { get; set; }
    [XmlElement(ElementName = "thirdPartyVoiceMailServerUserServer", IsNullable = true)]
    public string ThirdPartyVoiceMailServerUserServer { get; set; }
    [XmlElement(ElementName = "thirdPartyVoiceMailServerMailboxIdType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ThirdPartyVoiceMailSupportMailboxIdType ThirdPartyVoiceMailServerMailboxIdType { get; set; }
    [XmlElement(ElementName = "thirdPartyVoiceMailMailboxURL", IsNullable = true)]
    public string ThirdPartyVoiceMailMailboxURL { get; set; }
    [XmlElement(ElementName = "sipAuthenticationUserName", IsNullable = false)]
    public string SipAuthenticationUserName { get; set; }
    [XmlElement(ElementName = "newSipAuthenticationPassword", IsNullable = false)]
    public string NewSipAuthenticationPassword { get; set; }
    [XmlElement(ElementName = "OldSipAuthenticationPassword", IsNullable = false)]
    public string OldSipAuthenticationPassword { get; set; }
    [XmlElement(ElementName = "newPasscode", IsNullable = false)]
    public string NewPasscode { get; set; }
    [XmlElement(ElementName = "oldPasscode", IsNullable = false)]
    public string OldPasscode { get; set; }
    [XmlElement(ElementName = "impPassword", IsNullable = true)]
    public string ImpPassword { get; set; }
 }
}
