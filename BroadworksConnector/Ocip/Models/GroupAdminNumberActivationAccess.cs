using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Group Administrator's policy for accessing
    /// the Number Activation Control information.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupAdminNumberActivationAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "Read-Only")]
        ReadOnly,
            [XmlEnum(Name = "None")]
        None,
     }
}
