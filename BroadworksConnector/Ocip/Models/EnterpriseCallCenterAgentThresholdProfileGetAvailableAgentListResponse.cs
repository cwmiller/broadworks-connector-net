using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "agentTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AgentTable { get; set; }
 }
}
