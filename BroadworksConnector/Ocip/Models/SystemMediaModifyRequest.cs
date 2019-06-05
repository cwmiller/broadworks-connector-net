using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _mediaName;

    [XmlElement(ElementName = "mediaName", IsNullable = false, Namespace = "")]
    public string MediaName {
        get => _mediaName;
        set {
            MediaNameSpecified = true;
            _mediaName = value;
        }
    }

    [XmlIgnore]
    public bool MediaNameSpecified { get; set; }
    private string _codecName;

    [XmlElement(ElementName = "codecName", IsNullable = false, Namespace = "")]
    public string CodecName {
        get => _codecName;
        set {
            CodecNameSpecified = true;
            _codecName = value;
        }
    }

    [XmlIgnore]
    public bool CodecNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MediaBandwidthEnforcementType _bandwidthEnforcementType;

    [XmlElement(ElementName = "bandwidthEnforcementType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MediaBandwidthEnforcementType BandwidthEnforcementType {
        get => _bandwidthEnforcementType;
        set {
            BandwidthEnforcementTypeSpecified = true;
            _bandwidthEnforcementType = value;
        }
    }

    [XmlIgnore]
    public bool BandwidthEnforcementTypeSpecified { get; set; }
    private int? _mediaBandwidth;

    [XmlElement(ElementName = "mediaBandwidth", IsNullable = true, Namespace = "")]
    public int? MediaBandwidth {
        get => _mediaBandwidth;
        set {
            MediaBandwidthSpecified = true;
            _mediaBandwidth = value;
        }
    }

    [XmlIgnore]
    public bool MediaBandwidthSpecified { get; set; }
}
}
