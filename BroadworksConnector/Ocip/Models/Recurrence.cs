using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class Recurrence 
{
    [XmlElement(ElementName = "recurDaily", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RecurrenceRecurDaily RecurDaily { get; set; }
    [XmlElement(ElementName = "recurWeekly", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RecurrenceRecurWeekly RecurWeekly { get; set; }
    [XmlElement(ElementName = "recurMonthlyByDay", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RecurrenceRecurMonthlyByDay RecurMonthlyByDay { get; set; }
    [XmlElement(ElementName = "recurMonthlyByWeek", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RecurrenceRecurMonthlyByWeek RecurMonthlyByWeek { get; set; }
    [XmlElement(ElementName = "recurYearlyByDay", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RecurrenceRecurYearlyByDay RecurYearlyByDay { get; set; }
    [XmlElement(ElementName = "recurYearlyByWeek", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RecurrenceRecurYearlyByWeek RecurYearlyByWeek { get; set; }
    [XmlElement(ElementName = "recurForEver", IsNullable = false)]
    public bool RecurForEver { get; set; }
    [XmlElement(ElementName = "recurEndDate", IsNullable = false)]
    public string RecurEndDate { get; set; }
    [XmlElement(ElementName = "recurEndOccurrence", IsNullable = false)]
    public int RecurEndOccurrence { get; set; }
 }
}
