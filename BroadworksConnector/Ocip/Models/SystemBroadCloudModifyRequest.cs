using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system interface attributes for Messaging Server/BroadCloud.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2648""}]")]
    public class SystemBroadCloudModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _provisioningUrl;

        [XmlElement(ElementName = "provisioningUrl", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2648")]
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

        [XmlElement(ElementName = "provisioningUserId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2648")]
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

        protected string _provisioningPassword;

        [XmlElement(ElementName = "provisioningPassword", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2648")]
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

        protected bool _enableSynchronization;

        [XmlElement(ElementName = "enableSynchronization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2648")]
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

        [XmlElement(ElementName = "proxyHost", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2648")]
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
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2648")]
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
