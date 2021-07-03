using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the group level configuration for Exchange Integration.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:5674""}]")]
    public class GroupExchangeIntegrationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5674")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5674")]
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

        private bool _enableExchangeIntegration;

        [XmlElement(ElementName = "enableExchangeIntegration", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5674")]
        public bool EnableExchangeIntegration
        {
            get => _enableExchangeIntegration;
            set
            {
                EnableExchangeIntegrationSpecified = true;
                _enableExchangeIntegration = value;
            }
        }

        [XmlIgnore]
        protected bool EnableExchangeIntegrationSpecified { get; set; }

        private string _exchangeURL;

        [XmlElement(ElementName = "exchangeURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5674")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ExchangeURL
        {
            get => _exchangeURL;
            set
            {
                ExchangeURLSpecified = true;
                _exchangeURL = value;
            }
        }

        [XmlIgnore]
        protected bool ExchangeURLSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExchangeUserNamePassword _exchangeCredentials;

        [XmlElement(ElementName = "exchangeCredentials", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5674")]
        public BroadWorksConnector.Ocip.Models.ExchangeUserNamePassword ExchangeCredentials
        {
            get => _exchangeCredentials;
            set
            {
                ExchangeCredentialsSpecified = true;
                _exchangeCredentials = value;
            }
        }

        [XmlIgnore]
        protected bool ExchangeCredentialsSpecified { get; set; }

    }
}
