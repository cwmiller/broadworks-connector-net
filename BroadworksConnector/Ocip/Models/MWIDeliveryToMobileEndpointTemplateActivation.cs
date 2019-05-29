using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MWIDeliveryToMobileEndpointTemplateActivation 
{
    [XmlElement(ElementName = "language", IsNullable = false)]
    public string Language { get; set; }
    [XmlElement(ElementName = "type", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateType Type { get; set; }
    [XmlElement(ElementName = "isEnabled", IsNullable = false)]
    public bool IsEnabled { get; set; }
 }
}
