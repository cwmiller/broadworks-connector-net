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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2504"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2505""}]}]")]
    public class EnhancedCallLogsAccountAuthorizationCodeFilter
    {

        protected bool _callsWithCodes;

        [XmlElement(ElementName = "callsWithCodes", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2505")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2505")]
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
