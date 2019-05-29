using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterQueueStatistics13mp8 
{
    [XmlElement(ElementName = "numberOfIncomingCalls", IsNullable = false)]
    public int NumberOfIncomingCalls { get; set; }
    [XmlElement(ElementName = "numberOfCallsQueued", IsNullable = false)]
    public int NumberOfCallsQueued { get; set; }
    [XmlElement(ElementName = "numberOfBusyOverflows", IsNullable = false)]
    public int NumberOfBusyOverflows { get; set; }
    [XmlElement(ElementName = "numberOfCallsAnswered", IsNullable = false)]
    public int NumberOfCallsAnswered { get; set; }
    [XmlElement(ElementName = "averageTimeWithAgentSeconds", IsNullable = false)]
    public int AverageTimeWithAgentSeconds { get; set; }
    [XmlElement(ElementName = "averageTimeInQueueSeconds", IsNullable = false)]
    public int AverageTimeInQueueSeconds { get; set; }
    [XmlElement(ElementName = "averageNumberOfAgentsBusy", IsNullable = false)]
    public string AverageNumberOfAgentsBusy { get; set; }
    [XmlElement(ElementName = "averageNumberOfAgentsLoggedOff", IsNullable = false)]
    public string AverageNumberOfAgentsLoggedOff { get; set; }
    [XmlElement(ElementName = "averageHoldTimeBeforeCallLossSeconds", IsNullable = false)]
    public int AverageHoldTimeBeforeCallLossSeconds { get; set; }
 }
}
