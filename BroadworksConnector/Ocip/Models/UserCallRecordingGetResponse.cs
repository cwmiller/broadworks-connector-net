using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallRecordingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.RecordingOption _recordingOption;

    [XmlElement(ElementName = "recordingOption", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.RecordingOption RecordingOption {
        get => _recordingOption;
        set {
            RecordingOptionSpecified = true;
            _recordingOption = value;
        }
    }

    [XmlIgnore]
    public bool RecordingOptionSpecified { get; set; }
}
}
