using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListRequest14sp4 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "callLogType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallLogsType CallLogType { get; set; }
    [XmlElement(ElementName = "startingOffset", IsNullable = false)]
    public int StartingOffset { get; set; }
    [XmlElement(ElementName = "numCalls", IsNullable = false)]
    public int NumCalls { get; set; }
 }
}
