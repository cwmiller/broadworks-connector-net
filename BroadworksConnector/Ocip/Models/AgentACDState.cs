using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Agent Automatic Call Distribution (ACD) State.
    /// </summary>
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
