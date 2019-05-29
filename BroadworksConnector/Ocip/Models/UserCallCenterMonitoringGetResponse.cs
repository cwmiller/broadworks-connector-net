using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterMonitoringGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "playToneToAgentForSilentMonitoring", IsNullable = false)]
    public bool PlayToneToAgentForSilentMonitoring { get; set; }
 }
}
