using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Audio file codec.
    /// The following values are only used in XS data mode and will fail in AS data mode:
    /// EVRC0
    /// EVRCNW
    /// EVRCNW0
    /// The following values are only used in AS data mode and will fail in XS data mode:
    /// OPUS
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AudioFileCodec22
    {
        [XmlEnum(Name = "None")]
        None,
        [XmlEnum(Name = "G711")]
        G711,
        [XmlEnum(Name = "G722")]
        G722,
        [XmlEnum(Name = "G729")]
        G729,
        [XmlEnum(Name = "G726")]
        G726,
        [XmlEnum(Name = "AMR")]
        AMR,
        [XmlEnum(Name = "AMR-WB")]
        AMRWB,
        [XmlEnum(Name = "OPUS")]
        OPUS,
        [XmlEnum(Name = "EVRC0")]
        EVRC0,
        [XmlEnum(Name = "EVRCNW")]
        EVRCNW,
        [XmlEnum(Name = "EVRCNW0")]
        EVRCNW0,
    }
}
