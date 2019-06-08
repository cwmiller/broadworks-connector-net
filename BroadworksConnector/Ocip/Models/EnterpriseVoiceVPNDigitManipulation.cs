using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
[XmlInclude(typeof(BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationNoValue))]
[XmlInclude(typeof(BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOptionalValue))]
[XmlInclude(typeof(BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationRequiredValue))]
public abstract class EnterpriseVoiceVPNDigitManipulation 
{
}
}
