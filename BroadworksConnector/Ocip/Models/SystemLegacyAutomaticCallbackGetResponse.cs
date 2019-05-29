using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLegacyAutomaticCallbackGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "maxMonitorsPerOriginator", IsNullable = false)]
    public int MaxMonitorsPerOriginator { get; set; }
    [XmlElement(ElementName = "maxMonitorsPerTerminator", IsNullable = false)]
    public int MaxMonitorsPerTerminator { get; set; }
    [XmlElement(ElementName = "t2Minutes", IsNullable = false)]
    public int T2Minutes { get; set; }
    [XmlElement(ElementName = "t4Seconds", IsNullable = false)]
    public int T4Seconds { get; set; }
    [XmlElement(ElementName = "t5Seconds", IsNullable = false)]
    public int T5Seconds { get; set; }
    [XmlElement(ElementName = "t6Minutes", IsNullable = false)]
    public int T6Minutes { get; set; }
    [XmlElement(ElementName = "t7Minutes", IsNullable = false)]
    public int T7Minutes { get; set; }
    [XmlElement(ElementName = "t8Seconds", IsNullable = false)]
    public int T8Seconds { get; set; }
    [XmlElement(ElementName = "tRingSeconds", IsNullable = false)]
    public int TRingSeconds { get; set; }
    [XmlElement(ElementName = "t10OMinutes", IsNullable = false)]
    public int T10OMinutes { get; set; }
    [XmlElement(ElementName = "t10TMinutes", IsNullable = false)]
    public int T10TMinutes { get; set; }
 }
}
