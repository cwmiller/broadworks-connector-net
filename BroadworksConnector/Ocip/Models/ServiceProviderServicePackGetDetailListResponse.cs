using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackGetDetailListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "servicePackName", IsNullable = false)]
    public string ServicePackName { get; set; }
    [XmlElement(ElementName = "servicePackDescription", IsNullable = false)]
    public string ServicePackDescription { get; set; }
    [XmlElement(ElementName = "isAvailableForUse", IsNullable = false)]
    public bool IsAvailableForUse { get; set; }
    [XmlElement(ElementName = "servicePackQuantity", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedPositiveInt ServicePackQuantity { get; set; }
    [XmlElement(ElementName = "assignedQuantity", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedNonNegativeInt AssignedQuantity { get; set; }
    [XmlElement(ElementName = "allowedQuantity", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedPositiveInt AllowedQuantity { get; set; }
    [XmlElement(ElementName = "userServiceTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UserServiceTable { get; set; }
 }
}
