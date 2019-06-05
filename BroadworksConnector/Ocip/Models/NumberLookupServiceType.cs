using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum NumberLookupServiceType{
    [XmlEnum(Name = "BroadWorks Anywhere")]
    BroadWorksAnywhere,
 }
}
