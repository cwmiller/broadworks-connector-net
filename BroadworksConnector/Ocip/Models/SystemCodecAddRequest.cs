using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a codec to the ordered list of codecs supported by the system.
    /// The ordered list of codecs is sent to MGCP devices when creating connections.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5474""}]")]
    public class SystemCodecAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.Codec _codec;

        [XmlElement(ElementName = "codec", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5474")]
        public BroadWorksConnector.Ocip.Models.Codec Codec
        {
            get => _codec;
            set
            {
                CodecSpecified = true;
                _codec = value;
            }
        }

        [XmlIgnore]
        protected bool CodecSpecified { get; set; }

    }
}
