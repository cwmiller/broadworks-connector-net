using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// License type.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum LicenseStrictness    {
            [XmlEnum(Name = "Hard")]
        Hard,
            [XmlEnum(Name = "Soft")]
        Soft,
     }
}
