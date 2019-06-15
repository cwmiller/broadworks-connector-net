using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Filter criteria based on the account code.
    /// When "callsWithCodes" is set to true, all call logs with account/authorization codes are returned.
    /// When it set to false, all call logs without account/authorization codes are returned.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnhancedCallLogsAccountAuthorizationCodeFilter 
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
        
        private string _accountAuthorizationCode;

        [XmlElement(ElementName = "accountAuthorizationCode", IsNullable = false, Namespace = "")]
        public string AccountAuthorizationCode {
            get => _accountAuthorizationCode;
            set {
                AccountAuthorizationCodeSpecified = true;
                _accountAuthorizationCode = value;
            }
        }

        [XmlIgnore]
        public bool AccountAuthorizationCodeSpecified { get; set; }
        
    }
}
