using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class VerifyTranslationAndRoutingOrigination 
{
    [XmlElement(ElementName = "linePort", IsNullable = false)]
    public string LinePort { get; set; }
    [XmlElement(ElementName = "phone", IsNullable = false)]
    public string Phone { get; set; }
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "url", IsNullable = false)]
    public string Url { get; set; }
 }
}
