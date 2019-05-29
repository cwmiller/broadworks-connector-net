using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDirectoryNumberHuntingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "agentUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AgentUserTable { get; set; }
 }
}
