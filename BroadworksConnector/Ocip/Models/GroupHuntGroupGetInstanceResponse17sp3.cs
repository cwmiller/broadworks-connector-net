using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupHuntGroupGetInstanceResponse17sp3 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile17 ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "policy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HuntPolicy Policy { get; set; }
    [XmlElement(ElementName = "huntAfterNoAnswer", IsNullable = false)]
    public bool HuntAfterNoAnswer { get; set; }
    [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false)]
    public int NoAnswerNumberOfRings { get; set; }
    [XmlElement(ElementName = "forwardAfterTimeout", IsNullable = false)]
    public bool ForwardAfterTimeout { get; set; }
    [XmlElement(ElementName = "forwardTimeoutSeconds", IsNullable = false)]
    public int ForwardTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = false)]
    public string ForwardToPhoneNumber { get; set; }
    [XmlElement(ElementName = "agentUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AgentUserTable { get; set; }
    [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false)]
    public bool AllowCallWaitingForAgents { get; set; }
    [XmlElement(ElementName = "useSystemHuntGroupCLIDSetting", IsNullable = false)]
    public bool UseSystemHuntGroupCLIDSetting { get; set; }
    [XmlElement(ElementName = "includeHuntGroupNameInCLID", IsNullable = false)]
    public bool IncludeHuntGroupNameInCLID { get; set; }
 }
}
