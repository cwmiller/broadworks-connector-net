using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderScheduleModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "scheduleKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ScheduleKey ScheduleKey { get; set; }
    [XmlElement(ElementName = "newScheduleName", IsNullable = false)]
    public string NewScheduleName { get; set; }
 }
}
