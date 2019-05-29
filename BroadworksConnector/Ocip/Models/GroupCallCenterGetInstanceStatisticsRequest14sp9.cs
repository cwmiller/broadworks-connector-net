using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetInstanceStatisticsRequest14sp9 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "statisticsRange", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterStatisticsRange StatisticsRange { get; set; }
 }
}
