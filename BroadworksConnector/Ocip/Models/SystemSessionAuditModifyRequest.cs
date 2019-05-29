using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSessionAuditModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "intervalSeconds", IsNullable = false)]
    public int IntervalSeconds { get; set; }
    [XmlElement(ElementName = "timeoutPeriodSeconds", IsNullable = false)]
    public int TimeoutPeriodSeconds { get; set; }
 }
}
