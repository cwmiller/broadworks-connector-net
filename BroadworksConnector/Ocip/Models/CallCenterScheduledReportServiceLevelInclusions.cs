using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterScheduledReportServiceLevelInclusions 
{
    [XmlElement(ElementName = "includeOverflowTimeTransferedInServiceLevel", IsNullable = false)]
    public bool IncludeOverflowTimeTransferedInServiceLevel { get; set; }
    [XmlElement(ElementName = "includeOtherTransfersInServiceLevel", IsNullable = false)]
    public bool IncludeOtherTransfersInServiceLevel { get; set; }
    [XmlElement(ElementName = "abandonedCallsInServiceLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportAbadonedCallsInServiceLevel AbandonedCallsInServiceLevel { get; set; }
    [XmlElement(ElementName = "abandonedCallIntervalSeconds", IsNullable = false)]
    public int AbandonedCallIntervalSeconds { get; set; }
 }
}
