using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
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
