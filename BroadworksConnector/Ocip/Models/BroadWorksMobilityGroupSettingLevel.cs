using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum BroadWorksMobilityGroupSettingLevel
    {
        [XmlEnum(Name = "Group")]
        Group,
        [XmlEnum(Name = "ServiceProvider")]
        ServiceProvider,
    }
}
