using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Access level of the Hoteling Host Service
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum HotelingHostAccessLevel
    {
        [XmlEnum(Name = "Enterprise")]
        Enterprise,
        [XmlEnum(Name = "Group")]
        Group,
    }
}
