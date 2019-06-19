using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// CommPilot Express Voice Messaging Greeting Choices.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CommPilotExpressVoiceMailGreeting
    {
        [XmlEnum(Name = "No Answer")]
        NoAnswer,
        [XmlEnum(Name = "Unavailable")]
        Unavailable,
    }
}
