using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccountingInhibitedAttributeValuePairCodeDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "attributeValuePairCode", IsNullable = false)]
    public int AttributeValuePairCode { get; set; }
    [XmlElement(ElementName = "vendorId", IsNullable = false)]
    public int VendorId { get; set; }
 }
}
