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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:28123""}]")]
    public class SystemMediaAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _mediaName;

        [XmlElement(ElementName = "mediaName", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:28123")]
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
        protected bool MediaNameSpecified { get; set; }

        protected string _codecName;

        [XmlElement(ElementName = "codecName", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:28123")]
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
        protected bool CodecNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaType _mediaType;

        [XmlElement(ElementName = "mediaType", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:28123")]
        public BroadWorksConnector.Ocip.Models.MediaType MediaType
        {
            get => _mediaType;
            set
            {
                MediaTypeSpecified = true;
                _mediaType = value;
            }
        }

        [XmlIgnore]
        protected bool MediaTypeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaBandwidthEnforcementType _bandwidthEnforcementType;

        [XmlElement(ElementName = "bandwidthEnforcementType", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:28123")]
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
        protected bool BandwidthEnforcementTypeSpecified { get; set; }

        protected int _mediaBandwidth;

        [XmlElement(ElementName = "mediaBandwidth", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:28123")]
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
        protected bool MediaBandwidthSpecified { get; set; }

    }
}
