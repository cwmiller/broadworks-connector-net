using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityMobileNetworkGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "scfSignalingNetAddress", IsNullable = false)]
    public string ScfSignalingNetAddress { get; set; }
    [XmlElement(ElementName = "scfSignalingPort", IsNullable = false)]
    public int ScfSignalingPort { get; set; }
    [XmlElement(ElementName = "refreshPeriodSeconds", IsNullable = false)]
    public int RefreshPeriodSeconds { get; set; }
    [XmlElement(ElementName = "maxConsecutiveFailures", IsNullable = false)]
    public int MaxConsecutiveFailures { get; set; }
    [XmlElement(ElementName = "maxResponseWaitTimeMilliseconds", IsNullable = false)]
    public int MaxResponseWaitTimeMilliseconds { get; set; }
    [XmlElement(ElementName = "enableAnnouncementSuppression", IsNullable = false)]
    public bool EnableAnnouncementSuppression { get; set; }
    [XmlElement(ElementName = "serviceAccessCodeListName", IsNullable = false)]
    public string ServiceAccessCodeListName { get; set; }
 }
}
