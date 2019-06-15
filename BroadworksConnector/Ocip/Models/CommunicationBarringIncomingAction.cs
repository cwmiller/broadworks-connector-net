using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Possible incoming call actions for Communication Barring.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CommunicationBarringIncomingAction    {
            [XmlEnum(Name = "Allow")]
        Allow,
            [XmlEnum(Name = "Allow Timed")]
        AllowTimed,
            [XmlEnum(Name = "Block")]
        Block,
     }
}
