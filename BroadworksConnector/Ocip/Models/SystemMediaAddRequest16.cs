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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:11762""}]")]
    public class SystemMediaAddRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _mediaName;

        [XmlElement(ElementName = "mediaName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11762")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:11762")]
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

        protected string _mediaType;

        [XmlElement(ElementName = "mediaType", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11762")]
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
        protected bool MediaTypeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaBandwidthEnforcementType _bandwidthEnforcementType;

        [XmlElement(ElementName = "bandwidthEnforcementType", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11762")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:11762")]
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
