using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class VerifyTranslationAndRoutingParameters 
{
    [XmlElement(ElementName = "origination", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VerifyTranslationAndRoutingOrigination Origination { get; set; }
    [XmlElement(ElementName = "destination", IsNullable = false)]
    public string Destination { get; set; }
    [XmlElement(ElementName = "contact", IsNullable = false)]
    public string Contact { get; set; }
    [XmlElement(ElementName = "diversion", IsNullable = false)]
    public string Diversion { get; set; }
 }
}
