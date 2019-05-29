using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "placed", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.EnhancedCallLogsEntry> Placed { get; set; }
    [XmlElement(ElementName = "received", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.EnhancedCallLogsEntry> Received { get; set; }
    [XmlElement(ElementName = "missed", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.EnhancedCallLogsEntry> Missed { get; set; }
 }
}
