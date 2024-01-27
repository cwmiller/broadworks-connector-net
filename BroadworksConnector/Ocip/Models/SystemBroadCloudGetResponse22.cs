using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemBroadCloudGetRequest22.
    /// The response contains the system interface attributes for Messaging Server/BroadCloud.
    /// <see cref="SystemBroadCloudGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2628""}]")]
    public class SystemBroadCloudGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _provisioningUrl;

        [XmlElement(ElementName = "provisioningUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2628")]
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

        protected string _provisioningUserId;

        [XmlElement(ElementName = "provisioningUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2628")]
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

        protected bool _enableSynchronization;

        [XmlElement(ElementName = "enableSynchronization", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2628")]
        public bool EnableSynchronization
        {
            get => _enableSynchronization;
            set
            {
                EnableSynchronizationSpecified = true;
                _enableSynchronization = value;
            }
        }

        [XmlIgnore]
        protected bool EnableSynchronizationSpecified { get; set; }

        protected string _proxyHost;

        [XmlElement(ElementName = "proxyHost", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2628")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ProxyHost
        {
            get => _proxyHost;
            set
            {
                ProxyHostSpecified = true;
                _proxyHost = value;
            }
        }

        [XmlIgnore]
        protected bool ProxyHostSpecified { get; set; }

        protected int _proxyPort;

        [XmlElement(ElementName = "proxyPort", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2628")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int ProxyPort
        {
            get => _proxyPort;
            set
            {
                ProxyPortSpecified = true;
                _proxyPort = value;
            }
        }

        [XmlIgnore]
        protected bool ProxyPortSpecified { get; set; }

    }
}
