using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterScheduledServiceAction
    {
        [XmlEnum(Name = "None")]
        None,
        [XmlEnum(Name = "Busy")]
        Busy,
        [XmlEnum(Name = "Transfer")]
        Transfer,
    }
}
