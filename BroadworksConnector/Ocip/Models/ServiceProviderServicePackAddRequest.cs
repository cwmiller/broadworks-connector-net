using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "servicePackName", IsNullable = false)]
    public string ServicePackName { get; set; }
    [XmlElement(ElementName = "servicePackDescription", IsNullable = false)]
    public string ServicePackDescription { get; set; }
    [XmlElement(ElementName = "isAvailableForUse", IsNullable = false)]
    public bool IsAvailableForUse { get; set; }
    [XmlElement(ElementName = "servicePackQuantity", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedPositiveInt ServicePackQuantity { get; set; }
    [XmlElement(ElementName = "serviceName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.UserService> ServiceName { get; set; }
 }
}
