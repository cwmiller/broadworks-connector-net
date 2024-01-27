using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a group.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// serviceProviderExternalId
    /// groupExternalId
    /// 
    /// The following elements are ignored in AS and XS data mode:
    /// servicePolicy,
    /// callProcessingSliceId,
    /// provisioningSliceId,
    /// subscriberPartition.
    /// 
    /// The following elements are only used in XS data mode and ignored in AS mode:
    /// preferredDataCenter.
    /// Only Provisioning admin and above can change the preferredDataCenter.
    /// 
    /// The following elements are only used in XS data mode and ignored in AS data mode:
    /// defaultUserCallingLineIdPhoneNumber.
    /// 
    /// The following elements are optional for the group. If the elements are included,
    /// they will be either added, authorized, or modified on the group. Should any of the
    /// following elements be rejected to due existing system or service provider settings,
    /// the group will not be added and the response will be an ErrorResponse:
    /// domain
    /// admin
    /// minExtensionLength
    /// maxExtensionLength
    /// defaultExtensionLength
    /// servicePackAuthorization
    /// groupServiceAuthorizationAndAssignment
    /// userServiceAuthorization
    /// servicePack
    /// activatablePhoneNumber
    /// activatableDNRange
    /// routingProfile
    /// trunkGroupMaxActiveCalls
    /// trunkGroupBurstingMaxActiveCalls
    /// meetMeConferencingAllocatedPorts
    /// When a group or user service is included that is not activated, is not licensed,
    /// or not authorized to the service provider, the response will be an ErrorResponse.
    /// 
    /// If the group service authorized quantity is not included it will default to Unlimited.
    /// 
    /// If activatablePhoneNumber and activatableDNRange elements are included, when
    /// activate element is present, this value overrides the system group default
    /// activatable settings.
    /// If the activatablePhoneNumber and activatableDNRange element are included, the phone numbers are added to the service provider if they are available to be assigned to the group and not currently added to the service provider.
    /// The response is either an GroupConsolidatedAddResponse22 or an ErrorResponse or a SuccessResponse
    /// 
    /// The response returned is a
    /// -	SuccessResponse if all the data is successfully added.
    /// -	ErrorResponse if any data other than the DN validation/assignment fails.
    /// -	GroupConsolidatedAddResponse22 if any of the activatablePhoneNumber or activatableDNRange fails validation.
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupConsolidatedAddResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SuccessResponse"/>
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupConsolidatedAddResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:2998"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:2999""}]}]")]
    public class GroupConsolidatedAddRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.OCIResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2999")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _serviceProviderExternalId;

        [XmlElement(ElementName = "serviceProviderExternalId", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2999")]
        [MaxLength(36)]
        public string ServiceProviderExternalId
        {
            get => _serviceProviderExternalId;
            set
            {
                ServiceProviderExternalIdSpecified = true;
                _serviceProviderExternalId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderExternalIdSpecified { get; set; }

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        protected string _groupExternalId;

        [XmlElement(ElementName = "groupExternalId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MaxLength(36)]
        public string GroupExternalId
        {
            get => _groupExternalId;
            set
            {
                GroupExternalIdSpecified = true;
                _groupExternalId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupExternalIdSpecified { get; set; }

        protected string _defaultDomain;

        [XmlElement(ElementName = "defaultDomain", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultDomain
        {
            get => _defaultDomain;
            set
            {
                DefaultDomainSpecified = true;
                _defaultDomain = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultDomainSpecified { get; set; }

        protected int _userLimit;

        [XmlElement(ElementName = "userLimit", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinInclusive(1)]
        [MaxInclusive(999999)]
        public int UserLimit
        {
            get => _userLimit;
            set
            {
                UserLimitSpecified = true;
                _userLimit = value;
            }
        }

        [XmlIgnore]
        protected bool UserLimitSpecified { get; set; }

        protected string _groupName;

        [XmlElement(ElementName = "groupName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinLength(1)]
        [MaxLength(80)]
        public string GroupName
        {
            get => _groupName;
            set
            {
                GroupNameSpecified = true;
                _groupName = value;
            }
        }

        [XmlIgnore]
        protected bool GroupNameSpecified { get; set; }

        protected string _callingLineIdName;

        [XmlElement(ElementName = "callingLineIdName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinLength(1)]
        [MaxLength(80)]
        public string CallingLineIdName
        {
            get => _callingLineIdName;
            set
            {
                CallingLineIdNameSpecified = true;
                _callingLineIdName = value;
            }
        }

        [XmlIgnore]
        protected bool CallingLineIdNameSpecified { get; set; }

        protected string _timeZone;

        [XmlElement(ElementName = "timeZone", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinLength(1)]
        [MaxLength(127)]
        public string TimeZone
        {
            get => _timeZone;
            set
            {
                TimeZoneSpecified = true;
                _timeZone = value;
            }
        }

        [XmlIgnore]
        protected bool TimeZoneSpecified { get; set; }

        protected string _locationDialingCode;

        [XmlElement(ElementName = "locationDialingCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinLength(1)]
        [MaxLength(15)]
        public string LocationDialingCode
        {
            get => _locationDialingCode;
            set
            {
                LocationDialingCodeSpecified = true;
                _locationDialingCode = value;
            }
        }

        [XmlIgnore]
        protected bool LocationDialingCodeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Contact _contact;

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        public BroadWorksConnector.Ocip.Models.Contact Contact
        {
            get => _contact;
            set
            {
                ContactSpecified = true;
                _contact = value;
            }
        }

        [XmlIgnore]
        protected bool ContactSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StreetAddress _address;

        [XmlElement(ElementName = "address", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        public BroadWorksConnector.Ocip.Models.StreetAddress Address
        {
            get => _address;
            set
            {
                AddressSpecified = true;
                _address = value;
            }
        }

        [XmlIgnore]
        protected bool AddressSpecified { get; set; }

        protected string _servicePolicy;

        [XmlElement(ElementName = "servicePolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServicePolicy
        {
            get => _servicePolicy;
            set
            {
                ServicePolicySpecified = true;
                _servicePolicy = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePolicySpecified { get; set; }

        protected string _callProcessingSliceId;

        [XmlElement(ElementName = "callProcessingSliceId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinLength(1)]
        [MaxLength(80)]
        public string CallProcessingSliceId
        {
            get => _callProcessingSliceId;
            set
            {
                CallProcessingSliceIdSpecified = true;
                _callProcessingSliceId = value;
            }
        }

        [XmlIgnore]
        protected bool CallProcessingSliceIdSpecified { get; set; }

        protected string _provisioningSliceId;

        [XmlElement(ElementName = "provisioningSliceId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ProvisioningSliceId
        {
            get => _provisioningSliceId;
            set
            {
                ProvisioningSliceIdSpecified = true;
                _provisioningSliceId = value;
            }
        }

        [XmlIgnore]
        protected bool ProvisioningSliceIdSpecified { get; set; }

        protected string _subscriberPartition;

        [XmlElement(ElementName = "subscriberPartition", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SubscriberPartition
        {
            get => _subscriberPartition;
            set
            {
                SubscriberPartitionSpecified = true;
                _subscriberPartition = value;
            }
        }

        [XmlIgnore]
        protected bool SubscriberPartitionSpecified { get; set; }

        protected string _preferredDataCenter;

        [XmlElement(ElementName = "preferredDataCenter", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PreferredDataCenter
        {
            get => _preferredDataCenter;
            set
            {
                PreferredDataCenterSpecified = true;
                _preferredDataCenter = value;
            }
        }

        [XmlIgnore]
        protected bool PreferredDataCenterSpecified { get; set; }

        protected string _defaultUserCallingLineIdPhoneNumber;

        [XmlElement(ElementName = "defaultUserCallingLineIdPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinLength(1)]
        [MaxLength(23)]
        public string DefaultUserCallingLineIdPhoneNumber
        {
            get => _defaultUserCallingLineIdPhoneNumber;
            set
            {
                DefaultUserCallingLineIdPhoneNumberSpecified = true;
                _defaultUserCallingLineIdPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultUserCallingLineIdPhoneNumberSpecified { get; set; }

        protected List<string> _domain = new List<string>();

        [XmlElement(ElementName = "domain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> Domain
        {
            get => _domain;
            set
            {
                DomainSpecified = true;
                _domain = value;
            }
        }

        [XmlIgnore]
        protected bool DomainSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.GroupAdmin> _admin = new List<BroadWorksConnector.Ocip.Models.GroupAdmin>();

        [XmlElement(ElementName = "admin", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        public List<BroadWorksConnector.Ocip.Models.GroupAdmin> Admin
        {
            get => _admin;
            set
            {
                AdminSpecified = true;
                _admin = value;
            }
        }

        [XmlIgnore]
        protected bool AdminSpecified { get; set; }

        protected int _minExtensionLength;

        [XmlElement(ElementName = "minExtensionLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int MinExtensionLength
        {
            get => _minExtensionLength;
            set
            {
                MinExtensionLengthSpecified = true;
                _minExtensionLength = value;
            }
        }

        [XmlIgnore]
        protected bool MinExtensionLengthSpecified { get; set; }

        protected int _maxExtensionLength;

        [XmlElement(ElementName = "maxExtensionLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int MaxExtensionLength
        {
            get => _maxExtensionLength;
            set
            {
                MaxExtensionLengthSpecified = true;
                _maxExtensionLength = value;
            }
        }

        [XmlIgnore]
        protected bool MaxExtensionLengthSpecified { get; set; }

        protected int _defaultExtensionLength;

        [XmlElement(ElementName = "defaultExtensionLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int DefaultExtensionLength
        {
            get => _defaultExtensionLength;
            set
            {
                DefaultExtensionLengthSpecified = true;
                _defaultExtensionLength = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultExtensionLengthSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.GroupServiceAuthorizationAndAssignment> _groupServiceAuthorizationAndAssignment = new List<BroadWorksConnector.Ocip.Models.GroupServiceAuthorizationAndAssignment>();

        [XmlElement(ElementName = "groupServiceAuthorizationAndAssignment", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        public List<BroadWorksConnector.Ocip.Models.GroupServiceAuthorizationAndAssignment> GroupServiceAuthorizationAndAssignment
        {
            get => _groupServiceAuthorizationAndAssignment;
            set
            {
                GroupServiceAuthorizationAndAssignmentSpecified = true;
                _groupServiceAuthorizationAndAssignment = value;
            }
        }

        [XmlIgnore]
        protected bool GroupServiceAuthorizationAndAssignmentSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.UserServiceAuthorization> _userServiceAuthorization = new List<BroadWorksConnector.Ocip.Models.UserServiceAuthorization>();

        [XmlElement(ElementName = "userServiceAuthorization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        public List<BroadWorksConnector.Ocip.Models.UserServiceAuthorization> UserServiceAuthorization
        {
            get => _userServiceAuthorization;
            set
            {
                UserServiceAuthorizationSpecified = true;
                _userServiceAuthorization = value;
            }
        }

        [XmlIgnore]
        protected bool UserServiceAuthorizationSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.ServicePackAuthorization> _servicePackAuthorization = new List<BroadWorksConnector.Ocip.Models.ServicePackAuthorization>();

        [XmlElement(ElementName = "servicePackAuthorization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        public List<BroadWorksConnector.Ocip.Models.ServicePackAuthorization> ServicePackAuthorization
        {
            get => _servicePackAuthorization;
            set
            {
                ServicePackAuthorizationSpecified = true;
                _servicePackAuthorization = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackAuthorizationSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.ActivatableDN> _activatablePhoneNumber = new List<BroadWorksConnector.Ocip.Models.ActivatableDN>();

        [XmlElement(ElementName = "activatablePhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        public List<BroadWorksConnector.Ocip.Models.ActivatableDN> ActivatablePhoneNumber
        {
            get => _activatablePhoneNumber;
            set
            {
                ActivatablePhoneNumberSpecified = true;
                _activatablePhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool ActivatablePhoneNumberSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.ActivatableDNRange> _activatableDNRange = new List<BroadWorksConnector.Ocip.Models.ActivatableDNRange>();

        [XmlElement(ElementName = "activatableDNRange", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        public List<BroadWorksConnector.Ocip.Models.ActivatableDNRange> ActivatableDNRange
        {
            get => _activatableDNRange;
            set
            {
                ActivatableDNRangeSpecified = true;
                _activatableDNRange = value;
            }
        }

        [XmlIgnore]
        protected bool ActivatableDNRangeSpecified { get; set; }

        protected string _routingProfile;

        [XmlElement(ElementName = "routingProfile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        [MinLength(4)]
        [MaxLength(12)]
        public string RoutingProfile
        {
            get => _routingProfile;
            set
            {
                RoutingProfileSpecified = true;
                _routingProfile = value;
            }
        }

        [XmlIgnore]
        protected bool RoutingProfileSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MeetMeConferencingConferencePorts _meetMeConferencingAllocatedPorts;

        [XmlElement(ElementName = "meetMeConferencingAllocatedPorts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferencePorts MeetMeConferencingAllocatedPorts
        {
            get => _meetMeConferencingAllocatedPorts;
            set
            {
                MeetMeConferencingAllocatedPortsSpecified = true;
                _meetMeConferencingAllocatedPorts = value;
            }
        }

        [XmlIgnore]
        protected bool MeetMeConferencingAllocatedPortsSpecified { get; set; }

        protected int _trunkGroupMaxActiveCalls;

        [XmlElement(ElementName = "trunkGroupMaxActiveCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        public int TrunkGroupMaxActiveCalls
        {
            get => _trunkGroupMaxActiveCalls;
            set
            {
                TrunkGroupMaxActiveCallsSpecified = true;
                _trunkGroupMaxActiveCalls = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupMaxActiveCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _trunkGroupBurstingMaxActiveCalls;

        [XmlElement(ElementName = "trunkGroupBurstingMaxActiveCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2998")]
        public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt TrunkGroupBurstingMaxActiveCalls
        {
            get => _trunkGroupBurstingMaxActiveCalls;
            set
            {
                TrunkGroupBurstingMaxActiveCallsSpecified = true;
                _trunkGroupBurstingMaxActiveCalls = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupBurstingMaxActiveCallsSpecified { get; set; }

    }
}
