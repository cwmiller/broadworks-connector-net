using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ResellerIntegratedIMPGetRequest.
    /// The response contains the reseller Integrated IMP service attributes.
    /// 
    /// Replaced by: ResellerIntegratedIMPGetResponse22 in AS data mode
    /// <see cref="ResellerIntegratedIMPGetRequest"/>
    /// <see cref="ResellerIntegratedIMPGetResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:5385""}]")]
    public class ResellerIntegratedIMPGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useSystemServiceDomain;

        [XmlElement(ElementName = "useSystemServiceDomain", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5385")]
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

        [XmlElement(ElementName = "serviceDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5385")]
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

        private int _servicePort;

        [XmlElement(ElementName = "servicePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5385")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int ServicePort
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:5385")]
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

        [XmlElement(ElementName = "provisioningUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5385")]
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

        [XmlElement(ElementName = "provisioningUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5385")]
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

        private string _boshURL;

        [XmlElement(ElementName = "boshURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5385")]
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

    }
}
