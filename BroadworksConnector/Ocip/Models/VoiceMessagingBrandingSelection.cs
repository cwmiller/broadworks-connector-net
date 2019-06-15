using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Branding Selection.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum VoiceMessagingBrandingSelection    {
            [XmlEnum(Name = "Default")]
        Default,
            [XmlEnum(Name = "Branded")]
        Branded,
     }
}
