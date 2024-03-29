using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a service provider or enterprise.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// serviceProviderExtenalId
    /// provisioningSliceId
    /// 
    /// The following elements are ignored in AS and XS data mode:
    /// servicePolicy,
    /// callProcessingSliceId,
    /// subscriberPartition.
    /// 
    /// Only Provisioning admin and above can change the preferredDataCenter and provisioningSliceId.
    /// 
    /// The following data elements are only used in AS data mode:
    /// resellerId
    /// resellerName
    /// 
    /// The following elements are optional for the service provider. If the elements are included,
    /// they will be either added, authorized, or modified on the service provider. Should any of the
    /// following elements be rejected to due existing system settings, the service provider will not
    /// be added and the response will be an ErrorResponse:
    /// domain
    /// admin
    /// groupServiceAuthorization
    /// userServiceAuthorization
    /// servicePack
    /// phoneNumber
    /// dnRange
    /// routingProfile
    /// meetMeConferencingAllocatedPorts
    /// trunkGroupMaxActiveCalls
    /// trunkGroupBurstingMaxActiveCalls
    /// voiceMessagingGroupSettings
    /// voiceMessagingVoicePortalScope
    /// 
    /// When a group or user service is included that is not activated or is not licensed,
    /// the response will be an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:2726"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:2727""}]}]")]
    public class ServiceProviderConsolidatedAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _isEnterprise;

        [XmlElement(ElementName = "isEnterprise", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2727")]
        public bool IsEnterprise
        {
            get => _isEnterprise;
            set
            {
                IsEnterpriseSpecified = true;
                _isEnterprise = value;
            }
        }

        [XmlIgnore]
        protected bool IsEnterpriseSpecified { get; set; }

        protected bool _useCustomRoutingProfile;

        [XmlElement(ElementName = "useCustomRoutingProfile", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2727")]
        public bool UseCustomRoutingProfile
        {
            get => _useCustomRoutingProfile;
            set
            {
                UseCustomRoutingProfileSpecified = true;
                _useCustomRoutingProfile = value;
            }
        }

        [XmlIgnore]
        protected bool UseCustomRoutingProfileSpecified { get; set; }

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
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
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
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

        protected string _defaultDomain;

        [XmlElement(ElementName = "defaultDomain", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
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

        protected string _serviceProviderName;

        [XmlElement(ElementName = "serviceProviderName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServiceProviderName
        {
            get => _serviceProviderName;
            set
            {
                ServiceProviderNameSpecified = true;
                _serviceProviderName = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderNameSpecified { get; set; }

        protected string _supportEmail;

        [XmlElement(ElementName = "supportEmail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SupportEmail
        {
            get => _supportEmail;
            set
            {
                SupportEmailSpecified = true;
                _supportEmail = value;
            }
        }

        [XmlIgnore]
        protected bool SupportEmailSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Contact _contact;

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
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

        protected string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
        [MinLength(1)]
        [MaxLength(36)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

        protected string _resellerName;

        [XmlElement(ElementName = "resellerName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
        [MinLength(1)]
        [MaxLength(320)]
        public string ResellerName
        {
            get => _resellerName;
            set
            {
                ResellerNameSpecified = true;
                _resellerName = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerNameSpecified { get; set; }

        protected List<string> _domain = new List<string>();

        [XmlElement(ElementName = "domain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
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

        protected List<BroadWorksConnector.Ocip.Models.ServiceProviderAdmin> _admin = new List<BroadWorksConnector.Ocip.Models.ServiceProviderAdmin>();

        [XmlElement(ElementName = "admin", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
        public List<BroadWorksConnector.Ocip.Models.ServiceProviderAdmin> Admin
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

        protected List<BroadWorksConnector.Ocip.Models.GroupServiceAuthorization> _groupServiceAuthorization = new List<BroadWorksConnector.Ocip.Models.GroupServiceAuthorization>();

        [XmlElement(ElementName = "groupServiceAuthorization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
        public List<BroadWorksConnector.Ocip.Models.GroupServiceAuthorization> GroupServiceAuthorization
        {
            get => _groupServiceAuthorization;
            set
            {
                GroupServiceAuthorizationSpecified = true;
                _groupServiceAuthorization = value;
            }
        }

        [XmlIgnore]
        protected bool GroupServiceAuthorizationSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.UserServiceAuthorization> _userServiceAuthorization = new List<BroadWorksConnector.Ocip.Models.UserServiceAuthorization>();

        [XmlElement(ElementName = "userServiceAuthorization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
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

        protected List<BroadWorksConnector.Ocip.Models.ServicePack> _servicePack = new List<BroadWorksConnector.Ocip.Models.ServicePack>();

        [XmlElement(ElementName = "servicePack", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
        public List<BroadWorksConnector.Ocip.Models.ServicePack> ServicePack
        {
            get => _servicePack;
            set
            {
                ServicePackSpecified = true;
                _servicePack = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackSpecified { get; set; }

        protected List<string> _phoneNumber = new List<string>();

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
        [MinLength(1)]
        [MaxLength(23)]
        public List<string> PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumberSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.DNRange> _dnRange = new List<BroadWorksConnector.Ocip.Models.DNRange>();

        [XmlElement(ElementName = "dnRange", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
        public List<BroadWorksConnector.Ocip.Models.DNRange> DnRange
        {
            get => _dnRange;
            set
            {
                DnRangeSpecified = true;
                _dnRange = value;
            }
        }

        [XmlIgnore]
        protected bool DnRangeSpecified { get; set; }

        protected string _routingProfile;

        [XmlElement(ElementName = "routingProfile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
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

        protected BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _trunkGroupMaxActiveCalls;

        [XmlElement(ElementName = "trunkGroupMaxActiveCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
        public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt TrunkGroupMaxActiveCalls
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
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

        protected BroadWorksConnector.Ocip.Models.ServiceProviderVoiceMessagingGroupSettingsAdd _voiceMessagingGroupSettings;

        [XmlElement(ElementName = "voiceMessagingGroupSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderVoiceMessagingGroupSettingsAdd VoiceMessagingGroupSettings
        {
            get => _voiceMessagingGroupSettings;
            set
            {
                VoiceMessagingGroupSettingsSpecified = true;
                _voiceMessagingGroupSettings = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessagingGroupSettingsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderVoicePortalScope _voiceMessagingGroupVoicePortalScope;

        [XmlElement(ElementName = "voiceMessagingGroupVoicePortalScope", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:2726")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderVoicePortalScope VoiceMessagingGroupVoicePortalScope
        {
            get => _voiceMessagingGroupVoicePortalScope;
            set
            {
                VoiceMessagingGroupVoicePortalScopeSpecified = true;
                _voiceMessagingGroupVoicePortalScope = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessagingGroupVoicePortalScopeSpecified { get; set; }

    }
}
