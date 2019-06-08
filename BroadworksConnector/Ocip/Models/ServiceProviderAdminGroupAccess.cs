using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ServiceProviderAdminGroupAccess{
    [XmlEnum(Name = "Full")]
    Full,
    [XmlEnum(Name = "Restricted from Adding or Removing Groups")]
    RestrictedfromAddingorRemovingGroups,
    [XmlEnum(Name = "None")]
    None,
 }
}
