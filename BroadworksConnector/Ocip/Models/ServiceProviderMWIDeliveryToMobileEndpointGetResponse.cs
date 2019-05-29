using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderMWIDeliveryToMobileEndpointGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "templateActivationTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable TemplateActivationTable { get; set; }
 }
}
