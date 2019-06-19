using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Enterprise Trunk Route Exhaustion Action
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum EnterpriseTrunkRouteExhaustionAction
    {
        [XmlEnum(Name = "None")]
        None,
        [XmlEnum(Name = "Forward")]
        Forward,
    }
}
