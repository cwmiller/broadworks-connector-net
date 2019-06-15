using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupExchangeIntegrationGetRequest.
        /// <see cref="GroupExchangeIntegrationGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupExchangeIntegrationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _enableExchangeIntegration;

        [XmlElement(ElementName = "enableExchangeIntegration", IsNullable = false, Namespace = "")]
        public bool EnableExchangeIntegration {
            get => _enableExchangeIntegration;
            set {
                EnableExchangeIntegrationSpecified = true;
                _enableExchangeIntegration = value;
            }
        }

        [XmlIgnore]
        public bool EnableExchangeIntegrationSpecified { get; set; }
        
        private string _exchangeURL;

        [XmlElement(ElementName = "exchangeURL", IsNullable = false, Namespace = "")]
        public string ExchangeURL {
            get => _exchangeURL;
            set {
                ExchangeURLSpecified = true;
                _exchangeURL = value;
            }
        }

        [XmlIgnore]
        public bool ExchangeURLSpecified { get; set; }
        
        private string _exchangeUserName;

        [XmlElement(ElementName = "exchangeUserName", IsNullable = false, Namespace = "")]
        public string ExchangeUserName {
            get => _exchangeUserName;
            set {
                ExchangeUserNameSpecified = true;
                _exchangeUserName = value;
            }
        }

        [XmlIgnore]
        public bool ExchangeUserNameSpecified { get; set; }
        
    }
}
