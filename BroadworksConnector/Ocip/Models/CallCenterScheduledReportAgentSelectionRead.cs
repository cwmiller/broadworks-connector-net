using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterScheduledReportAgentSelectionRead 
{
    [XmlElement(ElementName = "allAgent", IsNullable = false)]
    public bool AllAgent { get; set; }
    [XmlElement(ElementName = "agentTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AgentTable { get; set; }
 }
}
