using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDTMFTransmissionGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "transmissionMethod", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DTMFTransmissionMethod TransmissionMethod { get; set; }
    [XmlElement(ElementName = "signalingContentType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DtmfTransmissionSignalingContentType SignalingContentType { get; set; }
 }
}
