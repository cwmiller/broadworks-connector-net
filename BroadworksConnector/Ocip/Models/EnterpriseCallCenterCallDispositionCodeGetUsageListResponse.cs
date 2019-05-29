using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterCallDispositionCodeGetUsageListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "callCenterTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CallCenterTable { get; set; }
 }
}
