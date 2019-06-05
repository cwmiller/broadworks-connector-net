using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseVoiceVPNDigitManipulationNoValue : BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation
    {
        private BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperationNoValue _operation;

        [XmlElement(ElementName = "operation", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperationNoValue Operation
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
    }
}
