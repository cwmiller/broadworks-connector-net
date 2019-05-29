using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class RecurrenceRecurMonthlyByDay 
{
    [XmlElement(ElementName = "recurInterval", IsNullable = false)]
    public int RecurInterval { get; set; }
    [XmlElement(ElementName = "dayOfMonth", IsNullable = false)]
    public int DayOfMonth { get; set; }
 }
}
