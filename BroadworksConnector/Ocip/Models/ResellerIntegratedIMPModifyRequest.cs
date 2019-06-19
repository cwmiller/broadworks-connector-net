using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Integrated IMP service attributes for the reseller.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""23389100b68cef3aa07ee12ac7a2bd16:145""}]")]
    public class ResellerIntegratedIMPModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:145")]
        [MinLength(1)]
        [MaxLength(30)]
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
        public bool ResellerIdSpecified { get; set; }

        private bool _useSystemServiceDomain;

        [XmlElement(ElementName = "useSystemServiceDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:145")]
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
        public bool UseSystemServiceDomainSpecified { get; set; }

        private string _serviceDomain;

        [XmlElement(ElementName = "serviceDomain", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:145")]
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
        public bool ServiceDomainSpecified { get; set; }

        private int? _servicePort;

        [XmlElement(ElementName = "servicePort", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:145")]
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
        public bool ServicePortSpecified { get; set; }

        private bool _useSystemMessagingServer;

        [XmlElement(ElementName = "useSystemMessagingServer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:145")]
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
        public bool UseSystemMessagingServerSpecified { get; set; }

        private string _provisioningUrl;

        [XmlElement(ElementName = "provisioningUrl", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:145")]
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
        public bool ProvisioningUrlSpecified { get; set; }

        private string _provisioningUserId;

        [XmlElement(ElementName = "provisioningUserId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:145")]
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
        public bool ProvisioningUserIdSpecified { get; set; }

        private string _provisioningPassword;

        [XmlElement(ElementName = "provisioningPassword", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:145")]
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
        public bool ProvisioningPasswordSpecified { get; set; }

        private string _boshURL;

        [XmlElement(ElementName = "boshURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:145")]
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
        public bool BoshURLSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.IntegratedIMPUserIDType _defaultImpIdType;

        [XmlElement(ElementName = "defaultImpIdType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:145")]
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
        public bool DefaultImpIdTypeSpecified { get; set; }

    }
}
