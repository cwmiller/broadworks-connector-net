using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Stir Shaken attestation.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum StirShakenAttestationLevel
    {
        [XmlEnum(Name = "Full")]
        Full,
        [XmlEnum(Name = "Partial")]
        Partial,
        [XmlEnum(Name = "Gateway")]
        Gateway,
    }
}
