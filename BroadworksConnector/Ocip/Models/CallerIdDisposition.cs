using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Caller Id Disposition value.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallerIdDisposition
    {
        [XmlEnum(Name = "Valid")]
        Valid,
        [XmlEnum(Name = "Invalid")]
        Invalid,
        [XmlEnum(Name = "Unverified")]
        Unverified,
        [XmlEnum(Name = "None")]
        None,
    }
}
