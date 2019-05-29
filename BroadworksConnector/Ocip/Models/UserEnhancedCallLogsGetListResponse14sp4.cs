using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListResponse14sp4 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "placed", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallLogsEntry> Placed { get; set; }
    [XmlElement(ElementName = "received", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallLogsEntry> Received { get; set; }
    [XmlElement(ElementName = "missed", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallLogsEntry> Missed { get; set; }
 }
}
