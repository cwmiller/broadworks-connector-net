using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallWaitingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private bool _playDistinctiveRingback;

    [XmlElement(ElementName = "playDistinctiveRingback", IsNullable = false, Namespace = "")]
    public bool PlayDistinctiveRingback {
        get => _playDistinctiveRingback;
        set {
            PlayDistinctiveRingbackSpecified = true;
            _playDistinctiveRingback = value;
        }
    }

    [XmlIgnore]
    public bool PlayDistinctiveRingbackSpecified { get; set; }
}
}
