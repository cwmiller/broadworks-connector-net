using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Audio file codec.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AudioFileCodec    {
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
     }
}
