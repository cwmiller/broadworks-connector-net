using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum NoChargeTreatmentHandling{
    [XmlEnum(Name = "Answer")]
    Answer,
    [XmlEnum(Name = "Early Media")]
    EarlyMedia,
 }
}
