using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the profile for a group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The following elements are only used in Amplify data mode and ignored
    /// in AS and XS data mode:
    /// servicePolicy,
    /// callProcessingSliceId,
    /// provisioningSliceId,
    /// subscriberPartition.
    /// When the callProcessingSliceId or provisioningSliceId is set to nillable,
    /// it will be assigned to the default Slice.
    /// Only Provisioning admin and above can change the callProcessingSliceId, provisioningSliceId, and subscriberPartition.
    /// 
    /// The following elements are only used in Amplify and XS data mode and ignored in AS data mode:
    /// preferredDataCenter.
    /// Only Provisioning admin and above can change the preferredDataCenter.
    /// 
    /// The following elements are only used in XS data mode and ignored in Amplify and AS data mode:
    /// defaultUserCallingLineIdPhoneNumber.
    /// 
    /// The following elements are only used in AS data mode and ignored in the XS data mode:
    /// extensionLengthSettings
    /// dialPlanAccessCode
    /// dialPlanPolicy
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:6433""}]")]
    public class GroupModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
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

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
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

        private string _defaultDomain;

        [XmlElement(ElementName = "defaultDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
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

        private int _userLimit;

        [XmlElement(ElementName = "userLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
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

        private string _groupName;

        [XmlElement(ElementName = "groupName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
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

        private string _callingLineIdName;

        [XmlElement(ElementName = "callingLineIdName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
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

        private string _callingLineIdPhoneNumber;

        [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
        [MinLength(1)]
        [MaxLength(23)]
        public string CallingLineIdPhoneNumber
        {
            get => _callingLineIdPhoneNumber;
            set
            {
                CallingLineIdPhoneNumberSpecified = true;
                _callingLineIdPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool CallingLineIdPhoneNumberSpecified { get; set; }

        private string _timeZone;

        [XmlElement(ElementName = "timeZone", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
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

        private string _locationDialingCode;

        [XmlElement(ElementName = "locationDialingCode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
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

        private BroadWorksConnector.Ocip.Models.Contact _contact;

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
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

        private BroadWorksConnector.Ocip.Models.StreetAddress _address;

        [XmlElement(ElementName = "address", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
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

        private string _servicePolicy;

        [XmlElement(ElementName = "servicePolicy", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
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

        private string _callProcessingSliceId;

        [XmlElement(ElementName = "callProcessingSliceId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
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

        private string _provisioningSliceId;

        [XmlElement(ElementName = "provisioningSliceId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
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

        private string _subscriberPartition;

        [XmlElement(ElementName = "subscriberPartition", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
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

        private string _preferredDataCenter;

        [XmlElement(ElementName = "preferredDataCenter", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
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

        private string _defaultUserCallingLineIdPhoneNumber;

        [XmlElement(ElementName = "defaultUserCallingLineIdPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
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

        private BroadWorksConnector.Ocip.Models.GroupExtensionLengthSettings _extensionLengthSettings;

        [XmlElement(ElementName = "extensionLengthSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
        public BroadWorksConnector.Ocip.Models.GroupExtensionLengthSettings ExtensionLengthSettings
        {
            get => _extensionLengthSettings;
            set
            {
                ExtensionLengthSettingsSpecified = true;
                _extensionLengthSettings = value;
            }
        }

        [XmlIgnore]
        protected bool ExtensionLengthSettingsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DialPlanPolicyAccessCode _dialPlanAccessCode;

        [XmlElement(ElementName = "dialPlanAccessCode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
        public BroadWorksConnector.Ocip.Models.DialPlanPolicyAccessCode DialPlanAccessCode
        {
            get => _dialPlanAccessCode;
            set
            {
                DialPlanAccessCodeSpecified = true;
                _dialPlanAccessCode = value;
            }
        }

        [XmlIgnore]
        protected bool DialPlanAccessCodeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DialPlanPolicy _dialPlanPolicy;

        [XmlElement(ElementName = "dialPlanPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:6433")]
        public BroadWorksConnector.Ocip.Models.DialPlanPolicy DialPlanPolicy
        {
            get => _dialPlanPolicy;
            set
            {
                DialPlanPolicySpecified = true;
                _dialPlanPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool DialPlanPolicySpecified { get; set; }

    }
}
