using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Auto Attendant type.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AutoAttendantType    {
            [XmlEnum(Name = "Basic")]
        Basic,
            [XmlEnum(Name = "Standard")]
        Standard,
     }
}
