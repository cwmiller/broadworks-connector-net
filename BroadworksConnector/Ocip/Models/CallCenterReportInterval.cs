using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterReportInterval 
{
    [XmlElement(ElementName = "dates", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportIntervalDates Dates { get; set; }
    [XmlElement(ElementName = "current", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportCurrentInterval Current { get; set; }
    [XmlElement(ElementName = "past", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportPastInterval Past { get; set; }
 }
}
