using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the profile for a service provider or enterprise.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The following elements are only used in Amplify data mode and ignored
    /// in AS and XS data mode:
    /// servicePolicy,
    /// callProcessingSliceId,
    /// provisioningSliceId,
    /// subscriberPartition.
    /// When the callProcessingSliceId or provisioningSliceId is set to nillable,
    /// it will be assigned to the default Slice.
    /// Only Provisioning admin and above can change the callProcessingSliceId,
    /// provisioningSliceId, and subscriberPartition.
    /// 
    /// The following element is only used in AS data mode and ignored
    /// in Amplify and XS data mode:
    /// resellerId
    /// resellerName
    /// 
    /// resellerId and resellerName can only be configured by a Reseller or higher level administrator.
    /// 
    /// The following behavior is only applicable in CloudPBX:
    /// - when existing resellerId is specified, enterprise/Service Provider shall be moved to
    /// requesting reseller.
    /// - when new resellerId, that does not exist in the system, is specified, the new
    /// Reseller is created the given resellerId and resellerName (if provided) and 	enterprise/Service Provider is moved to the newly created Reseller.
    /// 
    /// resellerName element is ignored if the reseller the service provider is being moved to 	already exists.
    /// 
    /// 
    /// The following elements are only used in Amplify and XS data mode and ignored in AS data mode:
    /// preferredDataCenter.
    /// Only Provisioning admin and above can change the preferredDataCenter.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// defaultExtensionLength
    /// locationRoutingPrefixDigit
    /// locationCodeLength
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4893""}]")]
    public class ServiceProviderModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4893")]
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

        private string _defaultDomain;

        [XmlElement(ElementName = "defaultDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4893")]
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

        private string _serviceProviderName;

        [XmlElement(ElementName = "serviceProviderName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4893")]
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

        private string _supportEmail;

        [XmlElement(ElementName = "supportEmail", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4893")]
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

        private BroadWorksConnector.Ocip.Models.Contact _contact;

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4893")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4893")]
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

        private bool _useServiceProviderLanguages;

        [XmlElement(ElementName = "useServiceProviderLanguages", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4893")]
        public bool UseServiceProviderLanguages
        {
            get => _useServiceProviderLanguages;
            set
            {
                UseServiceProviderLanguagesSpecified = true;
                _useServiceProviderLanguages = value;
            }
        }

        [XmlIgnore]
        protected bool UseServiceProviderLanguagesSpecified { get; set; }

        private string _servicePolicy;

        [XmlElement(ElementName = "servicePolicy", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4893")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4893")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4893")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4893")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4893")]
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

        private int? _defaultExtensionLength;

        [XmlElement(ElementName = "defaultExtensionLength", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4893")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int? DefaultExtensionLength
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

        private int? _locationRoutingPrefixDigit;

        [XmlElement(ElementName = "locationRoutingPrefixDigit", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4893")]
        [MinInclusive(0)]
        [MaxInclusive(9)]
        public int? LocationRoutingPrefixDigit
        {
            get => _locationRoutingPrefixDigit;
            set
            {
                LocationRoutingPrefixDigitSpecified = true;
                _locationRoutingPrefixDigit = value;
            }
        }

        [XmlIgnore]
        protected bool LocationRoutingPrefixDigitSpecified { get; set; }

        private int? _locationCodeLength;

        [XmlElement(ElementName = "locationCodeLength", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4893")]
        [MinInclusive(1)]
        [MaxInclusive(15)]
        public int? LocationCodeLength
        {
            get => _locationCodeLength;
            set
            {
                LocationCodeLengthSpecified = true;
                _locationCodeLength = value;
            }
        }

        [XmlIgnore]
        protected bool LocationCodeLengthSpecified { get; set; }

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4893")]
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

        private string _resellerName;

        [XmlElement(ElementName = "resellerName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4893")]
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

    }
}
