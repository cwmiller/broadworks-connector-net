using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a Media to the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10599""}]")]
    public class SystemMediaAddRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _mediaName;

        [XmlElement(ElementName = "mediaName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10599")]
        [MinLength(1)]
        [MaxLength(80)]
        public string MediaName
        {
            get => _mediaName;
            set
            {
                MediaNameSpecified = true;
                _mediaName = value;
            }
        }

        [XmlIgnore]
        public bool MediaNameSpecified { get; set; }

        private string _codecName;

        [XmlElement(ElementName = "codecName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10599")]
        [MinLength(1)]
        [MaxLength(80)]
        public string CodecName
        {
            get => _codecName;
            set
            {
                CodecNameSpecified = true;
                _codecName = value;
            }
        }

        [XmlIgnore]
        public bool CodecNameSpecified { get; set; }

        private string _mediaType;

        [XmlElement(ElementName = "mediaType", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10599")]
        [MinLength(1)]
        [MaxLength(127)]
        public string MediaType
        {
            get => _mediaType;
            set
            {
                MediaTypeSpecified = true;
                _mediaType = value;
            }
        }

        [XmlIgnore]
        public bool MediaTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaBandwidthEnforcementType _bandwidthEnforcementType;

        [XmlElement(ElementName = "bandwidthEnforcementType", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10599")]
        public BroadWorksConnector.Ocip.Models.MediaBandwidthEnforcementType BandwidthEnforcementType
        {
            get => _bandwidthEnforcementType;
            set
            {
                BandwidthEnforcementTypeSpecified = true;
                _bandwidthEnforcementType = value;
            }
        }

        [XmlIgnore]
        public bool BandwidthEnforcementTypeSpecified { get; set; }

        private int _mediaBandwidth;

        [XmlElement(ElementName = "mediaBandwidth", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10599")]
        [MinInclusive(1)]
        [MaxInclusive(100000000)]
        public int MediaBandwidth
        {
            get => _mediaBandwidth;
            set
            {
                MediaBandwidthSpecified = true;
                _mediaBandwidth = value;
            }
        }

        [XmlIgnore]
        public bool MediaBandwidthSpecified { get; set; }

    }
}
