using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseEnterpriseTrunkGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enterpriseTrunkTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable EnterpriseTrunkTable { get; set; }
 }
}
