using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum GroupDepartmentAdminPhoneNumberExtensionAccess{
    [XmlEnum(Name = "Full")]
    Full,
    [XmlEnum(Name = "Read-Only")]
    ReadOnly,
 }
}
