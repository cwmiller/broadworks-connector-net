using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Enterprise Voice VPN Digit Manipulation Entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationNoValue))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOptionalValue))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationRequiredValue))]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:1598""}]")]
    public abstract class EnterpriseVoiceVPNDigitManipulation
    {

    }
}
