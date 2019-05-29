using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallLogsClearRequest14sp4 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "deleteAllCallLogs", IsNullable = false)]
    public bool DeleteAllCallLogs { get; set; }
    [XmlElement(ElementName = "deleteSpecifiedCallLogs", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserCallLogsClearRequest14sp4DeleteSpecifiedCallLogs DeleteSpecifiedCallLogs { get; set; }
 }
}
