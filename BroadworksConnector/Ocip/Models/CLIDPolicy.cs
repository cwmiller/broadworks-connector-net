using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CLIDPolicy{
    [XmlEnum(Name = "Use DN")]
    UseDN,
    [XmlEnum(Name = "Use Configurable CLID")]
    UseConfigurableCLID,
 }
}
