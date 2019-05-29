using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkDeviceMonitorParametersModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "pollingIntervalMinutes", IsNullable = false)]
    public int PollingIntervalMinutes { get; set; }
    [XmlElement(ElementName = "failedPollingIntervalMinutes", IsNullable = false)]
    public int FailedPollingIntervalMinutes { get; set; }
 }
}
