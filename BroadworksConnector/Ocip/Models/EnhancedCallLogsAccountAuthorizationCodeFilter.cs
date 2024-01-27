using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:2986"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:2987""}]}]")]
    public class EnhancedCallLogsAccountAuthorizationCodeFilter
    {

        protected bool _callsWithCodes;

        [XmlElement(ElementName = "callsWithCodes", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2987")]
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

        protected string _accountAuthorizationCode;

        [XmlElement(ElementName = "accountAuthorizationCode", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2987")]
        [MinLength(2)]
        [MaxLength(14)]
        public string AccountAuthorizationCode
        {
            get => _accountAuthorizationCode;
            set
            {
                AccountAuthorizationCodeSpecified = true;
                _accountAuthorizationCode = value;
            }
        }

        [XmlIgnore]
        protected bool AccountAuthorizationCodeSpecified { get; set; }

    }
}
