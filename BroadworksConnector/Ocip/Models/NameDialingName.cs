using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class NameDialingName 
{
    [XmlElement(ElementName = "nameDialingLastName", IsNullable = false)]
    public string NameDialingLastName { get; set; }
    [XmlElement(ElementName = "nameDialingFirstName", IsNullable = false)]
    public string NameDialingFirstName { get; set; }
 }
}
