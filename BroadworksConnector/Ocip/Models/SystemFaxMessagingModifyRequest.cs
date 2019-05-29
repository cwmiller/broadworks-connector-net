using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemFaxMessagingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "statusDurationHours", IsNullable = false)]
    public int StatusDurationHours { get; set; }
    [XmlElement(ElementName = "statusAuditIntervalHours", IsNullable = false)]
    public int StatusAuditIntervalHours { get; set; }
    [XmlElement(ElementName = "maximumConcurrentFaxesPerUser", IsNullable = false)]
    public int MaximumConcurrentFaxesPerUser { get; set; }
 }
}
