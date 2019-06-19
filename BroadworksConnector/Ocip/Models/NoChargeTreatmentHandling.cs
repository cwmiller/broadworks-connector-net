using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// No charge treatments are handled by answering the call (via a 200 OK message)
    /// or with early media (via a 18x message)
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum NoChargeTreatmentHandling
    {
        [XmlEnum(Name = "Answer")]
        Answer,
        [XmlEnum(Name = "Early Media")]
        EarlyMedia,
    }
}
