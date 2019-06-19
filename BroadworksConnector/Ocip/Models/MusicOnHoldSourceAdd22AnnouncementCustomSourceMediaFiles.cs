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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2634""}]")]
    public class MusicOnHoldSourceAdd22AnnouncementCustomSourceMediaFiles
    {

        private BroadWorksConnector.Ocip.Models.AnnouncementFileKey _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2634")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileKey AudioFile
        {
            get => _audioFile;
            set
            {
                AudioFileSpecified = true;
                _audioFile = value;
            }
        }

        [XmlIgnore]
        public bool AudioFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileKey _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2634")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileKey VideoFile
        {
            get => _videoFile;
            set
            {
                VideoFileSpecified = true;
                _videoFile = value;
            }
        }

        [XmlIgnore]
        public bool VideoFileSpecified { get; set; }

    }
}
