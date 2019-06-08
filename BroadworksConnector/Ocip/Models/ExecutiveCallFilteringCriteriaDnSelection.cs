using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ExecutiveCallFilteringCriteriaDnSelection{
    [XmlEnum(Name = "Any")]
    Any,
    [XmlEnum(Name = "Any Internal")]
    AnyInternal,
    [XmlEnum(Name = "Any External")]
    AnyExternal,
    [XmlEnum(Name = "Specified Only")]
    SpecifiedOnly,
 }
}
