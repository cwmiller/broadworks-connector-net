using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnhancedCallLogsCallAuthorizationCodeFilter
    {
        private bool _callsWithCodes;

        [XmlElement(ElementName = "callsWithCodes", IsNullable = false, Namespace = "")]
        public bool CallsWithCodes
        {
            get => _callsWithCodes;
            set
            {
                CallsWithCodesSpecified = true;
                _callsWithCodes = value;
            }
        }

        [XmlIgnore]
        public bool CallsWithCodesSpecified { get; set; }
        private string _authorizationCode;

        [XmlElement(ElementName = "authorizationCode", IsNullable = false, Namespace = "")]
        public string AuthorizationCode
        {
            get => _authorizationCode;
            set
            {
                AuthorizationCodeSpecified = true;
                _authorizationCode = value;
            }
        }

        [XmlIgnore]
        public bool AuthorizationCodeSpecified { get; set; }
    }
}
