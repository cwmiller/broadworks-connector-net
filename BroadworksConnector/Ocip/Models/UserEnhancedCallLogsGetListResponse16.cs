using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListResponse16 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false)]
    public int TotalNumberOfRows { get; set; }
    [XmlElement(ElementName = "callLog", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.MixedCallLogsEntry> CallLog { get; set; }
 }
}
