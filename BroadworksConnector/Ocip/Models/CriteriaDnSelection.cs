using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CriteriaDnSelection{
    [XmlEnum(Name = "Any")]
    Any,
    [XmlEnum(Name = "Specified Only")]
    SpecifiedOnly,
 }
}
