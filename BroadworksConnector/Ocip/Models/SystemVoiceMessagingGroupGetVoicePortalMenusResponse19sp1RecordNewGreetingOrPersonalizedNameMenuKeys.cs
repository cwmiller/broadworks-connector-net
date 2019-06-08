using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1RecordNewGreetingOrPersonalizedNameMenuKeys 
{
    private string _endRecording;

    [XmlElement(ElementName = "endRecording", IsNullable = false, Namespace = "")]
    public string EndRecording {
        get => _endRecording;
        set {
            EndRecordingSpecified = true;
            _endRecording = value;
        }
    }

    [XmlIgnore]
    public bool EndRecordingSpecified { get; set; }
}
}
