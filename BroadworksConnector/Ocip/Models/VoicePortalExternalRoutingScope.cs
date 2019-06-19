using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the voice portal's external routing to decide which settings to use.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum VoicePortalExternalRoutingScope
    {
        [XmlEnum(Name = "System")]
        System,
        [XmlEnum(Name = "Group")]
        Group,
    }
}
