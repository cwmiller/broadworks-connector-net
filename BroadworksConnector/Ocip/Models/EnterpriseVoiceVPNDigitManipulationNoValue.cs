using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Enterprise Voice VPN Digit Manipulation Entry that has no value.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""405ec18fe08719ecf74e749d7e18c88f:1269""}]")]
    public class EnterpriseVoiceVPNDigitManipulationNoValue : BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation
    {

        protected BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperationNoValue _operation;

        [XmlElement(ElementName = "operation", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1269")]
        public BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperationNoValue Operation
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

    }
}
