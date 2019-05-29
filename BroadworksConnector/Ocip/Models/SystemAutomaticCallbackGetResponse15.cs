using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAutomaticCallbackGetResponse15 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "monitorMinutes", IsNullable = false)]
    public int MonitorMinutes { get; set; }
    [XmlElement(ElementName = "maxMonitorsPerOriginator", IsNullable = false)]
    public int MaxMonitorsPerOriginator { get; set; }
    [XmlElement(ElementName = "maxCallbackRings", IsNullable = false)]
    public int MaxCallbackRings { get; set; }
    [XmlElement(ElementName = "maxMonitorsPerTerminator", IsNullable = false)]
    public int MaxMonitorsPerTerminator { get; set; }
    [XmlElement(ElementName = "terminatorIdleGuardSeconds", IsNullable = false)]
    public int TerminatorIdleGuardSeconds { get; set; }
 }
}
