using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ExecutiveCallFilteringMode
    {
        [XmlEnum(Name = "Simple")]
        Simple,
        [XmlEnum(Name = "Advanced")]
        Advanced,
    }
}
