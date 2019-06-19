using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// System Administrator types.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SystemAdminType
    {
        [XmlEnum(Name = "System")]
        System,
        [XmlEnum(Name = "Provisioning")]
        Provisioning,
    }
}
