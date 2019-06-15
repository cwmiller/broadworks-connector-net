using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for how to extract the physical location from the P-Camel-CellDorLAI or P-Access-Network-Info header.
    /// CI indicates that the physical location comes from the Cell Identification (CI) field (5 digits) of the P-Camel-CellDorLAI header (5 digits).
    /// LAC-CI indicates that the physical location comes from the Location Area Code + Cell Identification (LAC+CI) fields of the P CAMEL CellIDorLAI header (10 digits).
    /// PANI indicates that the physical location comes from the P Network Address Info (PANI) header.  See RFC 3455.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum PhysicalLocationIndicator    {
            [XmlEnum(Name = "CI")]
        CI,
            [XmlEnum(Name = "LAC-CI")]
        LACCI,
            [XmlEnum(Name = "PANI")]
        PANI,
            [XmlEnum(Name = "Disregard Zones")]
        DisregardZones,
     }
}
