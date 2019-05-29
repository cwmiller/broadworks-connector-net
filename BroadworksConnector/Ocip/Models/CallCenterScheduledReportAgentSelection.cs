using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterScheduledReportAgentSelection 
{
    [XmlElement(ElementName = "allAgent", IsNullable = false)]
    public bool AllAgent { get; set; }
    [XmlElement(ElementName = "agentUserId", IsNullable = false)]
    public List<string> AgentUserId { get; set; }
 }
}
