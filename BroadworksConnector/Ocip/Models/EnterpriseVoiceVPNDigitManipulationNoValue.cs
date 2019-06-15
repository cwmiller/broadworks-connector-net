using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Enterprise Voice VPN Digit Manipulation Entry that has no value.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseVoiceVPNDigitManipulationNoValue : BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation
    {

        
        private BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperationNoValue _operation;

        [XmlElement(ElementName = "operation", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperationNoValue Operation {
            get => _operation;
            set {
                OperationSpecified = true;
                _operation = value;
            }
        }

        [XmlIgnore]
        public bool OperationSpecified { get; set; }
        
    }
}
