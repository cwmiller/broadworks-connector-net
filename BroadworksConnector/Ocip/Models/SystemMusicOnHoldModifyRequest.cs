using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMusicOnHoldModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private int _delayMilliseconds;

    [XmlElement(ElementName = "delayMilliseconds", IsNullable = false, Namespace = "")]
    public int DelayMilliseconds {
        get => _delayMilliseconds;
        set {
            DelayMillisecondsSpecified = true;
            _delayMilliseconds = value;
        }
    }

    [XmlIgnore]
    public bool DelayMillisecondsSpecified { get; set; }
}
}