using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDirectoryNumberHuntingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "agentUserIdList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList AgentUserIdList { get; set; }
    [XmlElement(ElementName = "useTerminateCallToAgentFirst", IsNullable = false)]
    public bool UseTerminateCallToAgentFirst { get; set; }
    [XmlElement(ElementName = "useOriginalAgentServicesForBusyAndNoAnswerCalls", IsNullable = false)]
    public bool UseOriginalAgentServicesForBusyAndNoAnswerCalls { get; set; }
 }
}
