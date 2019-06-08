using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDTMFTransmissionModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.DTMFTransmissionMethod _transmissionMethod;

    [XmlElement(ElementName = "transmissionMethod", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DTMFTransmissionMethod TransmissionMethod {
        get => _transmissionMethod;
        set {
            TransmissionMethodSpecified = true;
            _transmissionMethod = value;
        }
    }

    [XmlIgnore]
    public bool TransmissionMethodSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DtmfTransmissionSignalingContentType _signalingContentType;

    [XmlElement(ElementName = "signalingContentType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DtmfTransmissionSignalingContentType SignalingContentType {
        get => _signalingContentType;
        set {
            SignalingContentTypeSpecified = true;
            _signalingContentType = value;
        }
    }

    [XmlIgnore]
    public bool SignalingContentTypeSpecified { get; set; }
}
}
