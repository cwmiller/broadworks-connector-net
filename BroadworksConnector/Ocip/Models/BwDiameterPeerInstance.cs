using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum BwDiameterPeerInstance
    {
        [XmlEnum(Name = "XS")]
        XS,
        [XmlEnum(Name = "PS")]
        PS,
    }
}
