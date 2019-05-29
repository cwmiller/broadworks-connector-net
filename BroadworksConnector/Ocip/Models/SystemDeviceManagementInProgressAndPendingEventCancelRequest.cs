using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementInProgressAndPendingEventCancelRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "cancelAllEvents", IsNullable = false)]
    public string CancelAllEvents { get; set; }
    [XmlElement(ElementName = "cancelMultipleEvents", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemDeviceManagementInProgressAndPendingEventCancelRequestCancelMultipleEvents CancelMultipleEvents { get; set; }
    [XmlElement(ElementName = "eventId", IsNullable = false)]
    public List<int> EventId { get; set; }
 }
}
