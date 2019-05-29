using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterScheduledReportAgentSelectionAdminRead 
{
    [XmlElement(ElementName = "allAgent", IsNullable = false)]
    public bool AllAgent { get; set; }
    [XmlElement(ElementName = "currentAgentTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CurrentAgentTable { get; set; }
    [XmlElement(ElementName = "pastAgentTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable PastAgentTable { get; set; }
 }
}
