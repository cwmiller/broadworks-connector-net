using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AgentStatistics 
{
    [XmlElement(ElementName = "numberOfCallsHandled", IsNullable = false)]
    public int NumberOfCallsHandled { get; set; }
    [XmlElement(ElementName = "numberOfCallsUnanswered", IsNullable = false)]
    public int NumberOfCallsUnanswered { get; set; }
    [XmlElement(ElementName = "averageCallSeconds", IsNullable = false)]
    public int AverageCallSeconds { get; set; }
    [XmlElement(ElementName = "totalTalkSeconds", IsNullable = false)]
    public int TotalTalkSeconds { get; set; }
    [XmlElement(ElementName = "totalStaffedSeconds", IsNullable = false)]
    public int TotalStaffedSeconds { get; set; }
 }
}
