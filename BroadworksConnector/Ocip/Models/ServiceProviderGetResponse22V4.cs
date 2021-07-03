using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderGetRequest22V4.
    /// The response contains the service provider or enterprise's profile information.
    /// The following elements are only used in Amplify data mode and not returned
    /// in AS and XS data mode:
    /// servicePolicy,
    /// callProcessingSliceId,
    /// provisioningSliceId,
    /// subscriberPartition,
    /// preferredDataCenter.
    /// 
    /// The following elements are only used in Amplify and XS data mode and not
    /// returned in AS data mode:
    /// preferredDataCenter.
    /// 
    /// The following data elements are only used in AS data mode and not returned
    /// in XS data mode:
    /// resellerId,
    /// serviceProviderExternalId.
    /// <see cref="ServiceProviderGetRequest22V4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4583"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4584""}]}]")]
    public class ServiceProviderGetResponse22V4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isEnterprise;

        [XmlElement(ElementName = "isEnterprise", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4584")]
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

        private bool _useCustomRoutingProfile;

        [XmlElement(ElementName = "useCustomRoutingProfile", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4584")]
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

        private string _defaultDomain;

        [XmlElement(ElementName = "defaultDomain", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4583")]
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

        [XmlElement(ElementName = "serviceProviderName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4583")]
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

        [XmlElement(ElementName = "supportEmail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4583")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4583")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4583")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4583")]
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

        [XmlElement(ElementName = "servicePolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4583")]
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

        [XmlElement(ElementName = "callProcessingSliceId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4583")]
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

        [XmlElement(ElementName = "provisioningSliceId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4583")]
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

        [XmlElement(ElementName = "subscriberPartition", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4583")]
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

        [XmlElement(ElementName = "preferredDataCenter", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4583")]
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

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4583")]
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

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4583")]
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

        private string _serviceProviderExternalId;

        [XmlElement(ElementName = "serviceProviderExternalId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4583")]
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

    }
}
