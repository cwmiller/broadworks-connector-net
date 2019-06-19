using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The GETS Reserved Number type.
    /// AN - GETS-AN
    /// NT - GETS-NT
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GETSNumberType
    {
        [XmlEnum(Name = "AN")]
        AN,
        [XmlEnum(Name = "NT")]
        NT,
    }
}
