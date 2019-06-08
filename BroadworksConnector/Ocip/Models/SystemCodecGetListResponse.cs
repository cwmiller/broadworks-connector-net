using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCodecGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadWorksConnector.Ocip.Models.Codec> _codec;

    [XmlElement(ElementName = "codec", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.Codec> Codec {
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
