using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccountingInhibitedAttributeValuePairCodeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "inhibitedAttributeValuePairCodeTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable InhibitedAttributeValuePairCodeTable { get; set; }
 }
}
