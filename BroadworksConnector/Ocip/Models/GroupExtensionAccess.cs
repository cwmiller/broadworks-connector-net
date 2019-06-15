using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Group's policy for accessing extension dialing configuration (i.e. - length of extensions).
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupExtensionAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "Read-Only")]
        ReadOnly,
            [XmlEnum(Name = "None")]
        None,
     }
}
