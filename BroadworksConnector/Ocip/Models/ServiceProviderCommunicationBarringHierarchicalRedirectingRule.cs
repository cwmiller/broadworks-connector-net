using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderCommunicationBarringHierarchicalRedirectingRule 
{
    [XmlElement(ElementName = "criteria", IsNullable = false)]
    public string Criteria { get; set; }
    [XmlElement(ElementName = "digitPatternCriteria", IsNullable = false)]
    public string DigitPatternCriteria { get; set; }
    [XmlElement(ElementName = "action", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommunicationBarringRedirectingAction Action { get; set; }
    [XmlElement(ElementName = "callTimeoutSeconds", IsNullable = false)]
    public int CallTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "timeSchedule", IsNullable = false)]
    public string TimeSchedule { get; set; }
    [XmlElement(ElementName = "holidaySchedule", IsNullable = false)]
    public string HolidaySchedule { get; set; }
    [XmlElement(ElementName = "priority", IsNullable = false)]
    public decimal Priority { get; set; }
 }
}
