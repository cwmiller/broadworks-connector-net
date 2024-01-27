using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupExchangeIntegrationGetRequest.
    /// <see cref="GroupExchangeIntegrationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:5393""}]")]
    public class GroupExchangeIntegrationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableExchangeIntegration;

        [XmlElement(ElementName = "enableExchangeIntegration", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5393")]
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

        [XmlElement(ElementName = "exchangeURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5393")]
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

        protected string _exchangeUserName;

        [XmlElement(ElementName = "exchangeUserName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5393")]
        [MinLength(1)]
        [MaxLength(64)]
        public string ExchangeUserName
        {
            get => _exchangeUserName;
            set
            {
                ExchangeUserNameSpecified = true;
                _exchangeUserName = value;
            }
        }

        [XmlIgnore]
        protected bool ExchangeUserNameSpecified { get; set; }

    }
}
