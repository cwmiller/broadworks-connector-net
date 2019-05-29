using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAuthenticationModifyRequestPassword 
{
    [XmlElement(ElementName = "old", IsNullable = false)]
    public string Old { get; set; }
    [XmlElement(ElementName = "new", IsNullable = false)]
    public string New { get; set; }
 }
}
