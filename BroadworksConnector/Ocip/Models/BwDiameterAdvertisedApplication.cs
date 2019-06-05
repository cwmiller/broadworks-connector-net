using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum BwDiameterAdvertisedApplication
    {
        [XmlEnum(Name = "Base")]
        Base,
        [XmlEnum(Name = "3gpp")]
        _3gpp,
    }
}
