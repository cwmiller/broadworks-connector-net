using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterReportAbandonedCallThresholdReplacementList 
{
    [XmlElement(ElementName = "abandonedCallThresholdSeconds", IsNullable = false)]
    public List<int> AbandonedCallThresholdSeconds { get; set; }
 }
}
