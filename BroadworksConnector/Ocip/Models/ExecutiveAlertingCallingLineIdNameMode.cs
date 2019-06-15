using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Executive alerting calling line Id name mode.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ExecutiveAlertingCallingLineIdNameMode    {
            [XmlEnum(Name = "Executive")]
        Executive,
            [XmlEnum(Name = "Executive-Originator")]
        ExecutiveOriginator,
            [XmlEnum(Name = "Originator-Executive")]
        OriginatorExecutive,
            [XmlEnum(Name = "Originator")]
        Originator,
            [XmlEnum(Name = "Custom")]
        Custom,
     }
}
