using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Enterprise Voice VPN Digit Manipulation Operations that have no value.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum EnterpriseVoiceVPNDigitManipulationOperationNoValue    {
            [XmlEnum(Name = "End")]
        End,
     }
}
