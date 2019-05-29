using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MWIDeliveryToMobileEndpointTemplateLine 
{
    [XmlElement(ElementName = "prefix", IsNullable = false)]
    public string Prefix { get; set; }
    [XmlElement(ElementName = "tag", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateTag Tag { get; set; }
    [XmlElement(ElementName = "postfix", IsNullable = false)]
    public string Postfix { get; set; }
 }
}
