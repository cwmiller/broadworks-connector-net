using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAutomaticCallbackGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "monitorMinutes", IsNullable = false)]
    public int MonitorMinutes { get; set; }
    [XmlElement(ElementName = "waitBetweenRetryOriginatorMinutes", IsNullable = false)]
    public int WaitBetweenRetryOriginatorMinutes { get; set; }
    [XmlElement(ElementName = "maxMonitorsPerOriginator", IsNullable = false)]
    public int MaxMonitorsPerOriginator { get; set; }
    [XmlElement(ElementName = "maxCallbackRings", IsNullable = false)]
    public int MaxCallbackRings { get; set; }
    [XmlElement(ElementName = "maxRetryOriginatorMinutes", IsNullable = false)]
    public int MaxRetryOriginatorMinutes { get; set; }
 }
}
