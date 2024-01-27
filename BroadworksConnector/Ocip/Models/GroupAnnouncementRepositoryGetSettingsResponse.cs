using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAnnouncementFileGetSettingsRequest.
    /// The response contains the current total file size (KB) for the group across
    /// all media types and the maximum total file size (MB) allowed for the group.
    /// It also indicates the maximum file size for individual audio and video files.
    /// <see cref="GroupAnnouncementFileGetSettingsRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:2188""}]")]
    public class GroupAnnouncementRepositoryGetSettingsResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _totalFileSize;

        [XmlElement(ElementName = "totalFileSize", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2188")]
        public int TotalFileSize
        {
            get => _totalFileSize;
            set
            {
                TotalFileSizeSpecified = true;
                _totalFileSize = value;
            }
        }

        [XmlIgnore]
        protected bool TotalFileSizeSpecified { get; set; }

        protected int _maxAudioFileSize;

        [XmlElement(ElementName = "maxAudioFileSize", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2188")]
        public int MaxAudioFileSize
        {
            get => _maxAudioFileSize;
            set
            {
                MaxAudioFileSizeSpecified = true;
                _maxAudioFileSize = value;
            }
        }

        [XmlIgnore]
        protected bool MaxAudioFileSizeSpecified { get; set; }

        protected int _maxVideoFileSize;

        [XmlElement(ElementName = "maxVideoFileSize", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2188")]
        public int MaxVideoFileSize
        {
            get => _maxVideoFileSize;
            set
            {
                MaxVideoFileSizeSpecified = true;
                _maxVideoFileSize = value;
            }
        }

        [XmlIgnore]
        protected bool MaxVideoFileSizeSpecified { get; set; }

        protected int _maxFileSize;

        [XmlElement(ElementName = "maxFileSize", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2188")]
        [MinInclusive(1)]
        [MaxInclusive(999999)]
        public int MaxFileSize
        {
            get => _maxFileSize;
            set
            {
                MaxFileSizeSpecified = true;
                _maxFileSize = value;
            }
        }

        [XmlIgnore]
        protected bool MaxFileSizeSpecified { get; set; }

    }
}
