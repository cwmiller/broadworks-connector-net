using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterScheduledReportDNISSelection 
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "allDNIS", IsNullable = false)]
    public bool AllDNIS { get; set; }
    [XmlElement(ElementName = "name", IsNullable = false)]
    public List<string> Name { get; set; }
 }
}
