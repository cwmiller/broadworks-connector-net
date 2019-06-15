using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Identifies the roaming criteria to be matched.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum RoamingCriteria    {
            [XmlEnum(Name = "In Home Network")]
        InHomeNetwork,
            [XmlEnum(Name = "In Roaming Network")]
        InRoamingNetwork,
            [XmlEnum(Name = "Disregard Roaming")]
        DisregardRoaming,
     }
}
