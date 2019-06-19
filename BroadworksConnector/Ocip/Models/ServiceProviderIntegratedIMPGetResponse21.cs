using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderIntegratedIMPGetRequest21.
    /// The response contains the service provider Integrated IMP service attributes.
    /// If the service provider is within a reseller, useSystemServiceDomain means using reseller level service
    /// domain setting. And useSystemMessagingServer means using the reseller level messaging server setting.
    /// 
    /// Replaced by: ServiceProviderIntegratedIMPGetResponse21sp1 in AS data mode
    /// <see cref="ServiceProviderIntegratedIMPGetRequest21"/>
    /// <see cref="ServiceProviderIntegratedIMPGetResponse21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:5720""}]")]
    public class ServiceProviderIntegratedIMPGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useSystemServiceDomain;

        [XmlElement(ElementName = "useSystemServiceDomain", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5720")]
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

        [XmlElement(ElementName = "serviceDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5720")]
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

        private int _servicePort;

        [XmlElement(ElementName = "servicePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5720")]
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
        public bool ServicePortSpecified { get; set; }

        private bool _useSystemMessagingServer;

        [XmlElement(ElementName = "useSystemMessagingServer", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5720")]
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

        [XmlElement(ElementName = "provisioningUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5720")]
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

        [XmlElement(ElementName = "provisioningUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5720")]
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

        private string _boshURL;

        [XmlElement(ElementName = "boshURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5720")]
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

    }
}
