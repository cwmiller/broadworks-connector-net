using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Possible status values of a service pack migration task.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServicePackMigrationTaskUserSelectionType
    {
        [XmlEnum(Name = "All")]
        All,
        [XmlEnum(Name = "Any")]
        Any,
        [XmlEnum(Name = "None")]
        None,
    }
}
