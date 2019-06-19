using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Selection criteria for a call type.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SelectiveCallRejectionCriteriaCallTypeSelection
    {
        [XmlEnum(Name = "Any")]
        Any,
        [XmlEnum(Name = "Forwarded")]
        Forwarded,
        [XmlEnum(Name = "Specified Only")]
        SpecifiedOnly,
    }
}
