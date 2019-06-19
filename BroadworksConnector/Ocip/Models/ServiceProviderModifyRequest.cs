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
    /// The following elements are only used in Amplify and XS data mode and ignored in AS data mode:
    /// preferredDataCenter.
    /// Only Provisioning admin and above can change the preferredDataCenter.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4081""}]")]
    public class ServiceProviderModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4081")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private string _defaultDomain;

        [XmlElement(ElementName = "defaultDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4081")]
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
        public bool DefaultDomainSpecified { get; set; }

        private string _serviceProviderName;

        [XmlElement(ElementName = "serviceProviderName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4081")]
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
        public bool ServiceProviderNameSpecified { get; set; }

        private string _supportEmail;

        [XmlElement(ElementName = "supportEmail", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4081")]
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
        public bool SupportEmailSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.Contact _contact;

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4081")]
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
        public bool ContactSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.StreetAddress _address;

        [XmlElement(ElementName = "address", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4081")]
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
        public bool AddressSpecified { get; set; }

        private bool _useServiceProviderLanguages;

        [XmlElement(ElementName = "useServiceProviderLanguages", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4081")]
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
        public bool UseServiceProviderLanguagesSpecified { get; set; }

        private string _servicePolicy;

        [XmlElement(ElementName = "servicePolicy", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4081")]
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
        public bool ServicePolicySpecified { get; set; }

        private string _callProcessingSliceId;

        [XmlElement(ElementName = "callProcessingSliceId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4081")]
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
        public bool CallProcessingSliceIdSpecified { get; set; }

        private string _provisioningSliceId;

        [XmlElement(ElementName = "provisioningSliceId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4081")]
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
        public bool ProvisioningSliceIdSpecified { get; set; }

        private string _subscriberPartition;

        [XmlElement(ElementName = "subscriberPartition", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4081")]
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
        public bool SubscriberPartitionSpecified { get; set; }

        private string _preferredDataCenter;

        [XmlElement(ElementName = "preferredDataCenter", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4081")]
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
        public bool PreferredDataCenterSpecified { get; set; }

    }
}
