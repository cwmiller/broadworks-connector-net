using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterScheduledReportCallCenterSelectionRead 
{
    [XmlElement(ElementName = "allCallCenter", IsNullable = false)]
    public bool AllCallCenter { get; set; }
    [XmlElement(ElementName = "currentUserId", IsNullable = false)]
    public List<string> CurrentUserId { get; set; }
    [XmlElement(ElementName = "pastUserId", IsNullable = false)]
    public List<string> PastUserId { get; set; }
 }
}
