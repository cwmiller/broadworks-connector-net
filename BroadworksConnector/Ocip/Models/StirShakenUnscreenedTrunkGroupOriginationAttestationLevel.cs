using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Stir Shaken Unscreened Trunk Group Origination Attestation level.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum StirShakenUnscreenedTrunkGroupOriginationAttestationLevel
    {
        [XmlEnum(Name = "Full")]
        Full,
        [XmlEnum(Name = "Partial")]
        Partial,
        [XmlEnum(Name = "Gateway")]
        Gateway,
    }
}
