using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Identifies the source of the number used in the Calling Presentation Number field
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallingPresentationNumberSource
    {
        [XmlEnum(Name = "Configurable CLID")]
        ConfigurableCLID,
        [XmlEnum(Name = "DNIS")]
        DNIS,
        [XmlEnum(Name = "Emergency")]
        Emergency,
        [XmlEnum(Name = "Group")]
        Group,
        [XmlEnum(Name = "Trunk Group")]
        TrunkGroup,
        [XmlEnum(Name = "User")]
        User,
        [XmlEnum(Name = "Department")]
        Department,
    }
}
