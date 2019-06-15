using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// State of a trunk group.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupState    {
            [XmlEnum(Name = "Available")]
        Available,
            [XmlEnum(Name = "Unavailable")]
        Unavailable,
     }
}
