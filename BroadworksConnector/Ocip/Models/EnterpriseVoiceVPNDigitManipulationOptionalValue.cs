using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Enterprise Voice VPN Digit Manipulation Entry that optionally has a value.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""405ec18fe08719ecf74e749d7e18c88f:1284""}]")]
    public class EnterpriseVoiceVPNDigitManipulationOptionalValue : BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation
    {

        protected BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperationOptionalValue _operation;

        [XmlElement(ElementName = "operation", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1284")]
        public BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperationOptionalValue Operation
        {
            get => _operation;
            set
            {
                OperationSpecified = true;
                _operation = value;
            }
        }

        [XmlIgnore]
        protected bool OperationSpecified { get; set; }

        protected string _value;

        [XmlElement(ElementName = "value", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1284")]
        [MinLength(1)]
        [MaxLength(30)]
        public string Value
        {
            get => _value;
            set
            {
                ValueSpecified = true;
                _value = value;
            }
        }

        [XmlIgnore]
        protected bool ValueSpecified { get; set; }

    }
}
