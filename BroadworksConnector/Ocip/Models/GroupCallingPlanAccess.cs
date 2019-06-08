using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum GroupCallingPlanAccess{
    [XmlEnum(Name = "Full")]
    Full,
    [XmlEnum(Name = "Restricted")]
    Restricted,
 }
}
