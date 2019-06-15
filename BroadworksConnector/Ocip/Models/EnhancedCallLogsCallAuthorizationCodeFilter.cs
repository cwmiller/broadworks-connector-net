using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Filter criteria based on call authorization code. Note that this code
    /// filter is different than EnhancedCallLogsAccountAuthorizationCodeFilter,
    /// which applies strictly to codes entered using the account/authorization
    /// code service.
    /// When "callsWithCodes" is set to true, all call logs with authorization
    /// codes are returned.
    /// When it set to false, all call logs without authorization codes are
    /// returned.
    /// If "authorizationCode" is set, all call logs matching that specific
    /// authorization code are returned.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnhancedCallLogsCallAuthorizationCodeFilter 
    {

        
        private bool _callsWithCodes;

        [XmlElement(ElementName = "callsWithCodes", IsNullable = false, Namespace = "")]
        public bool CallsWithCodes {
            get => _callsWithCodes;
            set {
                CallsWithCodesSpecified = true;
                _callsWithCodes = value;
            }
        }

        [XmlIgnore]
        public bool CallsWithCodesSpecified { get; set; }
        
        private string _authorizationCode;

        [XmlElement(ElementName = "authorizationCode", IsNullable = false, Namespace = "")]
        public string AuthorizationCode {
            get => _authorizationCode;
            set {
                AuthorizationCodeSpecified = true;
                _authorizationCode = value;
            }
        }

        [XmlIgnore]
        public bool AuthorizationCodeSpecified { get; set; }
        
    }
}
