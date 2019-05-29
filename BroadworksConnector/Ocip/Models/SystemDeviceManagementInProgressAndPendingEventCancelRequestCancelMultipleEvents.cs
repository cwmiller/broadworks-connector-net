using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementInProgressAndPendingEventCancelRequestCancelMultipleEvents 
{
    [XmlElement(ElementName = "dmEventStatusForCancel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementEventStatusForCancel DmEventStatusForCancel { get; set; }
    [XmlElement(ElementName = "dmEventAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementEventAction DmEventAction { get; set; }
    [XmlElement(ElementName = "dmEventLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementEventLevel DmEventLevel { get; set; }
    [XmlElement(ElementName = "dmEventType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementEventType DmEventType { get; set; }
 }
}
