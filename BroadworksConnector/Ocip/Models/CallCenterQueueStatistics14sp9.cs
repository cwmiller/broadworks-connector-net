using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterQueueStatistics14sp9 
{
    [XmlElement(ElementName = "numberOfBusyOverflows", IsNullable = false)]
    public int NumberOfBusyOverflows { get; set; }
    [XmlElement(ElementName = "numberOfCallsAnswered", IsNullable = false)]
    public int NumberOfCallsAnswered { get; set; }
    [XmlElement(ElementName = "numberOfCallsAbandoned", IsNullable = false)]
    public int NumberOfCallsAbandoned { get; set; }
    [XmlElement(ElementName = "numberOfCallsTransferred", IsNullable = false)]
    public int NumberOfCallsTransferred { get; set; }
    [XmlElement(ElementName = "numberOfCallsTimedout", IsNullable = false)]
    public int NumberOfCallsTimedout { get; set; }
    [XmlElement(ElementName = "averageNumberOfAgentsTalking", IsNullable = false)]
    public string AverageNumberOfAgentsTalking { get; set; }
    [XmlElement(ElementName = "averageNumberOfAgentsStaffed", IsNullable = false)]
    public string AverageNumberOfAgentsStaffed { get; set; }
    [XmlElement(ElementName = "averageWaitSeconds", IsNullable = false)]
    public int AverageWaitSeconds { get; set; }
    [XmlElement(ElementName = "averageAbandonmentSeconds", IsNullable = false)]
    public int AverageAbandonmentSeconds { get; set; }
 }
}
