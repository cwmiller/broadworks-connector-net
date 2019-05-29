using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterGetResponse14sp9 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "defaultFromAddress", IsNullable = false)]
    public string DefaultFromAddress { get; set; }
    [XmlElement(ElementName = "statisticsSamplingPeriodMinutes", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterStatisticsSamplingPeriodMinutes StatisticsSamplingPeriodMinutes { get; set; }
 }
}
