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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:9728""}]")]
    public class SystemDTMFTransmissionGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.DTMFTransmissionMethod _transmissionMethod;

        [XmlElement(ElementName = "transmissionMethod", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:9728")]
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
        protected bool TransmissionMethodSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DtmfTransmissionSignalingContentType _signalingContentType;

        [XmlElement(ElementName = "signalingContentType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:9728")]
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
        protected bool SignalingContentTypeSpecified { get; set; }

    }
}
