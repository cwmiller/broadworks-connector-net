using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class RecordNewGreetingOrPersonalizedNameMenuKeysReadEntry 
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
