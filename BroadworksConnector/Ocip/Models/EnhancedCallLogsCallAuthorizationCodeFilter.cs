using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:3009"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:3010""}]}]")]
    public class EnhancedCallLogsCallAuthorizationCodeFilter
    {

        protected bool _callsWithCodes;

        [XmlElement(ElementName = "callsWithCodes", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3010")]
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
        protected bool CallsWithCodesSpecified { get; set; }

        protected string _authorizationCode;

        [XmlElement(ElementName = "authorizationCode", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3010")]
        [MinLength(2)]
        [MaxLength(14)]
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
        protected bool AuthorizationCodeSpecified { get; set; }

    }
}
