using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class AutoAttendantModifyMenuExecutionServer
    {
        private BroadworksConnector.Ocip.Models.AnnouncementSelection _announcementSelection;

        [XmlElement(ElementName = "announcementSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection
        {
            get => _announcementSelection;
            set
            {
                AnnouncementSelectionSpecified = true;
                _announcementSelection = value;
            }
        }

        [XmlIgnore]
        public bool AnnouncementSelectionSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.LabeledFileNameResource _audioFile;

        [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.LabeledFileNameResource AudioFile
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
        private BroadworksConnector.Ocip.Models.LabeledFileNameResource _videoFile;

        [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.LabeledFileNameResource VideoFile
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
