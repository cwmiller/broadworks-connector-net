using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ServiceProviderAdminCommunicationBarringAccess{
    [XmlEnum(Name = "Full")]
    Full,
    [XmlEnum(Name = "Read-Only")]
    ReadOnly,
 }
}
