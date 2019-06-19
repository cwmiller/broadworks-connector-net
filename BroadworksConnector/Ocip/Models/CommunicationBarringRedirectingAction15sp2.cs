using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Possible redirecting actions for Communication Barring.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CommunicationBarringRedirectingAction15sp2
    {
        [XmlEnum(Name = "Allow")]
        Allow,
        [XmlEnum(Name = "Block")]
        Block,
    }
}
