using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ChargingFunctionElementServerType
    {
        [XmlEnum(Name = "CCF")]
        CCF,
        [XmlEnum(Name = "ECF")]
        ECF,
    }
}
