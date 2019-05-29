using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallRecordingGetResponse23 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "continueCallAfterRecordingFailure", IsNullable = false)]
    public bool ContinueCallAfterRecordingFailure { get; set; }
    [XmlElement(ElementName = "maxResponseWaitTimeMilliseconds", IsNullable = false)]
    public int MaxResponseWaitTimeMilliseconds { get; set; }
    [XmlElement(ElementName = "continueCallAfterVideoRecordingFailure", IsNullable = false)]
    public bool ContinueCallAfterVideoRecordingFailure { get; set; }
    [XmlElement(ElementName = "useContinueCallAfterRecordingFailureForOnDemandMode", IsNullable = false)]
    public bool UseContinueCallAfterRecordingFailureForOnDemandMode { get; set; }
    [XmlElement(ElementName = "useContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartMode", IsNullable = false)]
    public bool UseContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartMode { get; set; }
    [XmlElement(ElementName = "restrictCallRecordingProvisioningAccess", IsNullable = false)]
    public bool RestrictCallRecordingProvisioningAccess { get; set; }
 }
}
