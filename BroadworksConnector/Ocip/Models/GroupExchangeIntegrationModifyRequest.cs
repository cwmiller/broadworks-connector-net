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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:5411""}]")]
    public class GroupExchangeIntegrationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5411")]
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

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5411")]
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

        protected bool _enableExchangeIntegration;

        [XmlElement(ElementName = "enableExchangeIntegration", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5411")]
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

        protected string _exchangeURL;

        [XmlElement(ElementName = "exchangeURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5411")]
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

        protected BroadWorksConnector.Ocip.Models.ExchangeUserNamePassword _exchangeCredentials;

        [XmlElement(ElementName = "exchangeCredentials", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5411")]
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
