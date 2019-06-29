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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:1616""}]")]
    public class GroupAnnouncementRepositoryGetSettingsResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _totalFileSize;

        [XmlElement(ElementName = "totalFileSize", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1616")]
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

        private int _maxAudioFileSize;

        [XmlElement(ElementName = "maxAudioFileSize", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1616")]
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

        private int _maxVideoFileSize;

        [XmlElement(ElementName = "maxVideoFileSize", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1616")]
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

        private int _maxFileSize;

        [XmlElement(ElementName = "maxFileSize", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1616")]
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
