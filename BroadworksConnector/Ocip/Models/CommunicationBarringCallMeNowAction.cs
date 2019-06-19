using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Possible Call Me Now actions for Communication Barring.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CommunicationBarringCallMeNowAction
    {
        [XmlEnum(Name = "Allow")]
        Allow,
        [XmlEnum(Name = "Allow Timed")]
        AllowTimed,
        [XmlEnum(Name = "Block")]
        Block,
    }
}
