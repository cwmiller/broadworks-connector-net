using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCodecDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.Codec _codec;

    [XmlElement(ElementName = "codec", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.Codec Codec {
        get => _codec;
        set {
            CodecSpecified = true;
            _codec = value;
        }
    }

    [XmlIgnore]
    public bool CodecSpecified { get; set; }
}
}
