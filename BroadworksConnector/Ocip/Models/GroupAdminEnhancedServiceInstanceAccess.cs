using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum GroupAdminEnhancedServiceInstanceAccess{
    [XmlEnum(Name = "Full")]
    Full,
    [XmlEnum(Name = "Modify-Only")]
    ModifyOnly,
 }
}
