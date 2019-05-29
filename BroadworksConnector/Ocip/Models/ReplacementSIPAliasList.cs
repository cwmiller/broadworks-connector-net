using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementSIPAliasList 
{
    [XmlElement(ElementName = "sipAlias", IsNullable = false)]
    public List<string> SipAlias { get; set; }
 }
}
