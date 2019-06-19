using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for originating trunk group format.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SIPOriginatingTrunkGroupFormat
    {
        [XmlEnum(Name = "OTG")]
        OTG,
        [XmlEnum(Name = "X Nortel Profile")]
        XNortelProfile,
    }
}
