using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterScheduledReportCallCenterSelection 
{
    [XmlElement(ElementName = "allCallCenter", IsNullable = false)]
    public bool AllCallCenter { get; set; }
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public List<string> ServiceUserId { get; set; }
 }
}
