using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum PriorityAlertCriteriaFromDnSelection{
    [XmlEnum(Name = "Any External")]
    AnyExternal,
    [XmlEnum(Name = "Specified Only")]
    SpecifiedOnly,
 }
}
