using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DtmfTransmissionSignalingContentType
    {
        [XmlEnum(Name = "application/dtmf")]
        Applicationdtmf,
        [XmlEnum(Name = "application/dtmf-relay")]
        Applicationdtmfrelay,
        [XmlEnum(Name = "audio/telephone-event")]
        Audiotelephoneevent,
    }
}
