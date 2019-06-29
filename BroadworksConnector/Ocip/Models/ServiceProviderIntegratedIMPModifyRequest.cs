using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Integrated IMP service attributes for the service provider.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// If the service provider is within a reseller, useSystemServiceDomain means using reseller level service
    /// domain setting. And useSystemMessagingServer means using the reseller level messaging server setting.
    /// 
    /// The following elements are only used in AS data mode:
    /// servicePort
    /// useSystemMessagingServer
    /// provisioningUrl
    /// provisioningUserId
    /// provisioningPassword
    /// boshURL
    /// defaultImpIdType
    /// useResellerIMPIdSetting
    /// 
    /// The element useResellerIMPIdSetting is only applicable for a service provider within a reseller.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""23389100b68cef3aa07ee12ac7a2bd16:229"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""23389100b68cef3aa07ee12ac7a2bd16:239"",""optional"":true}]}]")]
    public class ServiceProviderIntegratedIMPModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:229")]
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

        private bool _useSystemServiceDomain;

        [XmlElement(ElementName = "useSystemServiceDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:229")]
        public bool UseSystemServiceDomain
        {
            get => _useSystemServiceDomain;
            set
            {
                UseSystemServiceDomainSpecified = true;
                _useSystemServiceDomain = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemServiceDomainSpecified { get; set; }

        private string _serviceDomain;

        [XmlElement(ElementName = "serviceDomain", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:229")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServiceDomain
        {
            get => _serviceDomain;
            set
            {
                ServiceDomainSpecified = true;
                _serviceDomain = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceDomainSpecified { get; set; }

        private int? _servicePort;

        [XmlElement(ElementName = "servicePort", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:229")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int? ServicePort
        {
            get => _servicePort;
            set
            {
                ServicePortSpecified = true;
                _servicePort = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePortSpecified { get; set; }

        private bool _useSystemMessagingServer;

        [XmlElement(ElementName = "useSystemMessagingServer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:229")]
        public bool UseSystemMessagingServer
        {
            get => _useSystemMessagingServer;
            set
            {
                UseSystemMessagingServerSpecified = true;
                _useSystemMessagingServer = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemMessagingServerSpecified { get; set; }

        private string _provisioningUrl;

        [XmlElement(ElementName = "provisioningUrl", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:229")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ProvisioningUrl
        {
            get => _provisioningUrl;
            set
            {
                ProvisioningUrlSpecified = true;
                _provisioningUrl = value;
            }
        }

        [XmlIgnore]
        protected bool ProvisioningUrlSpecified { get; set; }

        private string _provisioningUserId;

        [XmlElement(ElementName = "provisioningUserId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:229")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ProvisioningUserId
        {
            get => _provisioningUserId;
            set
            {
                ProvisioningUserIdSpecified = true;
                _provisioningUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ProvisioningUserIdSpecified { get; set; }

        private string _provisioningPassword;

        [XmlElement(ElementName = "provisioningPassword", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:229")]
        [MinLength(1)]
        [MaxLength(20)]
        public string ProvisioningPassword
        {
            get => _provisioningPassword;
            set
            {
                ProvisioningPasswordSpecified = true;
                _provisioningPassword = value;
            }
        }

        [XmlIgnore]
        protected bool ProvisioningPasswordSpecified { get; set; }

        private string _boshURL;

        [XmlElement(ElementName = "boshURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:229")]
        [MinLength(1)]
        [MaxLength(256)]
        public string BoshURL
        {
            get => _boshURL;
            set
            {
                BoshURLSpecified = true;
                _boshURL = value;
            }
        }

        [XmlIgnore]
        protected bool BoshURLSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.IntegratedIMPUserIDType _defaultImpIdType;

        [XmlElement(ElementName = "defaultImpIdType", IsNullable = false, Namespace = "")]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:239")]
        public BroadWorksConnector.Ocip.Models.IntegratedIMPUserIDType DefaultImpIdType
        {
            get => _defaultImpIdType;
            set
            {
                DefaultImpIdTypeSpecified = true;
                _defaultImpIdType = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultImpIdTypeSpecified { get; set; }

        private bool _useResellerIMPIdSetting;

        [XmlElement(ElementName = "useResellerIMPIdSetting", IsNullable = false, Namespace = "")]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:239")]
        public bool UseResellerIMPIdSetting
        {
            get => _useResellerIMPIdSetting;
            set
            {
                UseResellerIMPIdSettingSpecified = true;
                _useResellerIMPIdSetting = value;
            }
        }

        [XmlIgnore]
        protected bool UseResellerIMPIdSettingSpecified { get; set; }

    }
}
