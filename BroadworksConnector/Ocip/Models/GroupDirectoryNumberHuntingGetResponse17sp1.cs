using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDirectoryNumberHuntingGetResponse17sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "agentUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AgentUserTable { get; set; }
    [XmlElement(ElementName = "useTerminateCallToAgentFirst", IsNullable = false)]
    public bool UseTerminateCallToAgentFirst { get; set; }
    [XmlElement(ElementName = "useOriginalAgentServicesForBusyAndNoAnswerCalls", IsNullable = false)]
    public bool UseOriginalAgentServicesForBusyAndNoAnswerCalls { get; set; }
 }
}
