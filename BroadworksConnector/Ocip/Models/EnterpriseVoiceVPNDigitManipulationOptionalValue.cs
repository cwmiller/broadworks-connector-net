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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:1623""}]")]
    public class EnterpriseVoiceVPNDigitManipulationOptionalValue : BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation
    {

        private BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperationOptionalValue _operation;

        [XmlElement(ElementName = "operation", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1623")]
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
        public bool OperationSpecified { get; set; }

        private string _value;

        [XmlElement(ElementName = "value", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1623")]
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
        public bool ValueSpecified { get; set; }

    }
}
