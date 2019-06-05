using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDTMFTransmissionGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.DTMFTransmissionMethod _transmissionMethod;

    [XmlElement(ElementName = "transmissionMethod", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.DTMFTransmissionMethod TransmissionMethod {
        get => _transmissionMethod;
        set {
            TransmissionMethodSpecified = true;
            _transmissionMethod = value;
        }
    }

    [XmlIgnore]
    public bool TransmissionMethodSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.DtmfTransmissionSignalingContentType _signalingContentType;

    [XmlElement(ElementName = "signalingContentType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.DtmfTransmissionSignalingContentType SignalingContentType {
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
