using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityMobileNetworkModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "newName", IsNullable = false)]
    public string NewName { get; set; }
    [XmlElement(ElementName = "scfSignalingNetAddress", IsNullable = true)]
    public string ScfSignalingNetAddress { get; set; }
    [XmlElement(ElementName = "scfSignalingPort", IsNullable = true)]
    public int? ScfSignalingPort { get; set; }
    [XmlElement(ElementName = "refreshPeriodSeconds", IsNullable = false)]
    public int RefreshPeriodSeconds { get; set; }
    [XmlElement(ElementName = "maxConsecutiveFailures", IsNullable = false)]
    public int MaxConsecutiveFailures { get; set; }
    [XmlElement(ElementName = "maxResponseWaitTimeMilliseconds", IsNullable = false)]
    public int MaxResponseWaitTimeMilliseconds { get; set; }
    [XmlElement(ElementName = "enableAnnouncementSuppression", IsNullable = false)]
    public bool EnableAnnouncementSuppression { get; set; }
    [XmlElement(ElementName = "serviceAccessCodeListName", IsNullable = true)]
    public string ServiceAccessCodeListName { get; set; }
 }
}
