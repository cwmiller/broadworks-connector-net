using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MWIDeliveryToMobileEndpointTemplateBody 
{
    [XmlElement(ElementName = "line", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateLine> Line { get; set; }
 }
}
