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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3a0309eb8d406fefc891f554ef114669:444""}]")]
    public class MusicOnHoldUserSourceReadRIUrlSource
    {

        protected string _audioUrl;

        [XmlElement(ElementName = "audioUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3a0309eb8d406fefc891f554ef114669:444")]
        [MinLength(1)]
        [MaxLength(256)]
        public string AudioUrl
        {
            get => _audioUrl;
            set
            {
                AudioUrlSpecified = (value != null);
                _audioUrl = value;
            }
        }

        [XmlIgnore]
        protected bool AudioUrlSpecified { get; set; }

        protected string _videoUrl;

        [XmlElement(ElementName = "videoUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3a0309eb8d406fefc891f554ef114669:444")]
        [MinLength(1)]
        [MaxLength(256)]
        public string VideoUrl
        {
            get => _videoUrl;
            set
            {
                VideoUrlSpecified = (value != null);
                _videoUrl = value;
            }
        }

        [XmlIgnore]
        protected bool VideoUrlSpecified { get; set; }

    }
}
