using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterAgentStatistics14sp9 
{
    [XmlElement(ElementName = "agentUserId", IsNullable = false)]
    public string AgentUserId { get; set; }
    [XmlElement(ElementName = "agentDisplayNames", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserDisplayNames AgentDisplayNames { get; set; }
    [XmlElement(ElementName = "available", IsNullable = false)]
    public bool Available { get; set; }
    [XmlElement(ElementName = "statistics", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AgentStatistics Statistics { get; set; }
 }
}
