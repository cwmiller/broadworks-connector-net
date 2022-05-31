using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCodecGetListRequest.
    /// <see cref="SystemCodecGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5520""}]")]
    public class SystemCodecGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.Codec> _codec = new List<BroadWorksConnector.Ocip.Models.Codec>();

        [XmlElement(ElementName = "codec", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5520")]
        public List<BroadWorksConnector.Ocip.Models.Codec> Codec
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
