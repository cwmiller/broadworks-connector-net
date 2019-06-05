using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum GroupCLIDPolicy{
    [XmlEnum(Name = "Use DN")]
    UseDN,
    [XmlEnum(Name = "Use Configurable CLID")]
    UseConfigurableCLID,
    [XmlEnum(Name = "Use Group CLID")]
    UseGroupCLID,
 }
}
