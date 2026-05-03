using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4266""}]")]
    public class MusicOnHoldSourceModifyRIV3UrlSource
    {

        protected string _audioUrl;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "audioUrl", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4266")]
        [MinLength(1)]
        [MaxLength(256)]
        public string AudioUrl
        {
            get => _audioUrl;
            set
            {
                AudioUrlSpecified = true;
                _audioUrl = value;
            }
        }

        [XmlIgnore]
        protected bool AudioUrlSpecified { get; set; }

        protected string _videoUrl;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "videoUrl", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4266")]
        [MinLength(1)]
        [MaxLength(256)]
        public string VideoUrl
        {
            get => _videoUrl;
            set
            {
                VideoUrlSpecified = true;
                _videoUrl = value;
            }
        }

        [XmlIgnore]
        protected bool VideoUrlSpecified { get; set; }

    }
}
