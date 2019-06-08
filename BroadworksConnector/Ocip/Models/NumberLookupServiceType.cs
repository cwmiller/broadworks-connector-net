using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum NumberLookupServiceType{
    [XmlEnum(Name = "BroadWorks Anywhere")]
    BroadWorksAnywhere,
 }
}
