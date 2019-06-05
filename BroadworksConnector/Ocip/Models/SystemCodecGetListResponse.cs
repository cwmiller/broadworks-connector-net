using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCodecGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.Codec> _codec;

    [XmlElement(ElementName = "codec", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.Codec> Codec {
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
