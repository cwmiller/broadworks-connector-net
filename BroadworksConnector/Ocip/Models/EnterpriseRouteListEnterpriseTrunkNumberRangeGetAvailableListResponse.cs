using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "availableNumberRangeTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AvailableNumberRangeTable { get; set; }
 }
}
