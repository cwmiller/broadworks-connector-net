using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallRecordingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "continueCallAfterRecordingFailure", IsNullable = false)]
    public bool ContinueCallAfterRecordingFailure { get; set; }
    [XmlElement(ElementName = "refreshPeriodSeconds", IsNullable = false)]
    public int RefreshPeriodSeconds { get; set; }
    [XmlElement(ElementName = "maxConsecutiveFailures", IsNullable = false)]
    public int MaxConsecutiveFailures { get; set; }
    [XmlElement(ElementName = "maxResponseWaitTimeMilliseconds", IsNullable = false)]
    public int MaxResponseWaitTimeMilliseconds { get; set; }
    [XmlElement(ElementName = "continueCallAfterVideoRecordingFailure", IsNullable = false)]
    public bool ContinueCallAfterVideoRecordingFailure { get; set; }
 }
}
