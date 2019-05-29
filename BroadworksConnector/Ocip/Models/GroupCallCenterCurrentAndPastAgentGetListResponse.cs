using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterCurrentAndPastAgentGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "agentUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AgentUserTable { get; set; }
    [XmlElement(ElementName = "deletedAgentUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DeletedAgentUserTable { get; set; }
 }
}
