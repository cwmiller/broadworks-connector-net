using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBusyLampFieldModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "listURI", IsNullable = true)]
    public string ListURI { get; set; }
    [XmlElement(ElementName = "monitoredUserIdList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList MonitoredUserIdList { get; set; }
    [XmlElement(ElementName = "enableCallParkNotification", IsNullable = false)]
    public bool EnableCallParkNotification { get; set; }
 }
}
