using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemDTMFTransmissionGetRequest.
    /// <see cref="SystemDTMFTransmissionGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8581""}]")]
    public class SystemDTMFTransmissionGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.DTMFTransmissionMethod _transmissionMethod;

        [XmlElement(ElementName = "transmissionMethod", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8581")]
        public BroadWorksConnector.Ocip.Models.DTMFTransmissionMethod TransmissionMethod
        {
            get => _transmissionMethod;
            set
            {
                TransmissionMethodSpecified = true;
                _transmissionMethod = value;
            }
        }

        [XmlIgnore]
        public bool TransmissionMethodSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DtmfTransmissionSignalingContentType _signalingContentType;

        [XmlElement(ElementName = "signalingContentType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8581")]
        public BroadWorksConnector.Ocip.Models.DtmfTransmissionSignalingContentType SignalingContentType
        {
            get => _signalingContentType;
            set
            {
                SignalingContentTypeSpecified = true;
                _signalingContentType = value;
            }
        }

        [XmlIgnore]
        public bool SignalingContentTypeSpecified { get; set; }

    }
}
