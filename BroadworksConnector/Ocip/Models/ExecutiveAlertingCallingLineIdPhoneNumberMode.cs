using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Executive alerting calling line Id phone number mode.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ExecutiveAlertingCallingLineIdPhoneNumberMode
    {
        [XmlEnum(Name = "Executive")]
        Executive,
        [XmlEnum(Name = "Originator")]
        Originator,
        [XmlEnum(Name = "Custom")]
        Custom,
    }
}
