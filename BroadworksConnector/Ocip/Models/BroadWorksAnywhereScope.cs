using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum BroadWorksAnywhereScope
    {
        [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
        [XmlEnum(Name = "Group")]
        Group,
    }
}
