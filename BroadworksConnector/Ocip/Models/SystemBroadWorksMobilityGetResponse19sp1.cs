using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityGetResponse19sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableLocationServices", IsNullable = false)]
    public bool EnableLocationServices { get; set; }
    [XmlElement(ElementName = "enableMSRNLookup", IsNullable = false)]
    public bool EnableMSRNLookup { get; set; }
    [XmlElement(ElementName = "enableMobileStateChecking", IsNullable = false)]
    public bool EnableMobileStateChecking { get; set; }
    [XmlElement(ElementName = "denyCallOriginations", IsNullable = false)]
    public bool DenyCallOriginations { get; set; }
    [XmlElement(ElementName = "denyCallTerminations", IsNullable = false)]
    public bool DenyCallTerminations { get; set; }
    [XmlElement(ElementName = "imrnTimeoutMillisecnds", IsNullable = false)]
    public int ImrnTimeoutMillisecnds { get; set; }
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
 }
}
