using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class RecurrenceRecurYearlyByWeek 
{
    [XmlElement(ElementName = "recurInterval", IsNullable = false)]
    public int RecurInterval { get; set; }
    [XmlElement(ElementName = "dayOfWeek", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DayOfWeek DayOfWeek { get; set; }
    [XmlElement(ElementName = "dayOfWeekInMonth", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DayOfWeekInMonth DayOfWeekInMonth { get; set; }
    [XmlElement(ElementName = "month", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.Month Month { get; set; }
 }
}
