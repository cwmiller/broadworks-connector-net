using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Agent Automatic Call Distribution (ACD) State.
    /// States available for Wrap-Up agent state management.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AgentACDAutomaticState
    {
        [XmlEnum(Name = "Available")]
        Available,
        [XmlEnum(Name = "Unavailable")]
        Unavailable,
        [XmlEnum(Name = "Wrap-Up")]
        WrapUp,
    }
}
