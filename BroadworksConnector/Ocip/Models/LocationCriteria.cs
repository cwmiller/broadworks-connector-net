using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Identifies the location zone criteria to be matched.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum LocationCriteria    {
            [XmlEnum(Name = "In Office Zone")]
        InOfficeZone,
            [XmlEnum(Name = "In Primary Zone")]
        InPrimaryZone,
            [XmlEnum(Name = "In Office Zone, Outside of Primary Zone")]
        InOfficeZoneOutsideofPrimaryZone,
            [XmlEnum(Name = "Outside of Office Zone")]
        OutsideofOfficeZone,
            [XmlEnum(Name = "Disregard Zones")]
        DisregardZones,
     }
}
