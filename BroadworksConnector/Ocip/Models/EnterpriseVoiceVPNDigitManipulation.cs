using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    [XmlInclude(typeof(BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationNoValue))]
    [XmlInclude(typeof(BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOptionalValue))]
    [XmlInclude(typeof(BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationRequiredValue))]
    public abstract class EnterpriseVoiceVPNDigitManipulation
    {
    }
}
