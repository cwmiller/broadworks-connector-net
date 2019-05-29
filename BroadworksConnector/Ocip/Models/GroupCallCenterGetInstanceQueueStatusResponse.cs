using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetInstanceQueueStatusResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "numberOfCallsQueuedNow", IsNullable = false)]
    public int NumberOfCallsQueuedNow { get; set; }
    [XmlElement(ElementName = "agentsCurrentlyStaffed", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AgentsCurrentlyStaffed { get; set; }
 }
}
