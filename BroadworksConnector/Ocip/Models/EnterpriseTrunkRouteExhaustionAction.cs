using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
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
