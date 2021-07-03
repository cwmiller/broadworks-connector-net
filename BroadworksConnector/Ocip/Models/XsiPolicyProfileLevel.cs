using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The system Xsi policy profile level.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum XsiPolicyProfileLevel
    {
        [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
        [XmlEnum(Name = "Group")]
        Group,
        [XmlEnum(Name = "User")]
        User,
    }
}
