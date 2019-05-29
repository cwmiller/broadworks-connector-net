using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementUserIdList 
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public List<string> UserId { get; set; }
 }
}
