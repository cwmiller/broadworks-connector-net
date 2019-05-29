using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isEnabled", IsNullable = false)]
    public bool IsEnabled { get; set; }
    [XmlElement(ElementName = "templateBody", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateBody TemplateBody { get; set; }
 }
}
