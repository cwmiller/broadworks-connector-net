using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AgentACDState
    {
        [XmlEnum(Name = "Sign-In")]
        SignIn,
        [XmlEnum(Name = "Sign-Out")]
        SignOut,
        [XmlEnum(Name = "Available")]
        Available,
        [XmlEnum(Name = "Unavailable")]
        Unavailable,
        [XmlEnum(Name = "Wrap-Up")]
        WrapUp,
    }
}
