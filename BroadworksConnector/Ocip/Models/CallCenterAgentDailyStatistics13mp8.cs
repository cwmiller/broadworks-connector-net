using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterAgentDailyStatistics13mp8 
{
    [XmlElement(ElementName = "numberOfCallsReceived", IsNullable = false)]
    public int NumberOfCallsReceived { get; set; }
    [XmlElement(ElementName = "numberOfCallsNotAnswered", IsNullable = false)]
    public int NumberOfCallsNotAnswered { get; set; }
    [XmlElement(ElementName = "averageTimePerCallSeconds", IsNullable = false)]
    public int AverageTimePerCallSeconds { get; set; }
    [XmlElement(ElementName = "timeInCallsSeconds", IsNullable = false)]
    public int TimeInCallsSeconds { get; set; }
    [XmlElement(ElementName = "timeLoggedOffSeconds", IsNullable = false)]
    public int TimeLoggedOffSeconds { get; set; }
    [XmlElement(ElementName = "timeLoggedOnAndIdleSeconds", IsNullable = false)]
    public int TimeLoggedOnAndIdleSeconds { get; set; }
 }
}
