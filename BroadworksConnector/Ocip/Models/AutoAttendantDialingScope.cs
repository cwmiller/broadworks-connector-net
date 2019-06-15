using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The scope of extension or name dialing.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AutoAttendantDialingScope    {
            [XmlEnum(Name = "Enterprise")]
        Enterprise,
            [XmlEnum(Name = "Group")]
        Group,
            [XmlEnum(Name = "Department")]
        Department,
     }
}
