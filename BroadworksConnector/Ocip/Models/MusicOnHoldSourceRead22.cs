using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains the music on hold source configuration.
    /// The following elements are only used in XS data mode and not returned in AS data mode:
    /// labeledCustomSourceMediaFiles
    /// The following elements are only used in AS data mode and not returned in XS data mode:
    /// announcementMediaFiles
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class MusicOnHoldSourceRead22 
    {

        
        private BroadWorksConnector.Ocip.Models.AudioFileCodec22 _audioFilePreferredCodec;

        [XmlElement(ElementName = "audioFilePreferredCodec", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AudioFileCodec22 AudioFilePreferredCodec {
            get => _audioFilePreferredCodec;
            set {
                AudioFilePreferredCodecSpecified = true;
                _audioFilePreferredCodec = value;
            }
        }

        [XmlIgnore]
        public bool AudioFilePreferredCodecSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MusicOnHoldMessageSelection _messageSourceSelection;

        [XmlElement(ElementName = "messageSourceSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldMessageSelection MessageSourceSelection {
            get => _messageSourceSelection;
            set {
                MessageSourceSelectionSpecified = true;
                _messageSourceSelection = value;
            }
        }

        [XmlIgnore]
        public bool MessageSourceSelectionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22LabeledCustomSourceMediaFiles _labeledCustomSourceMediaFiles;

        [XmlElement(ElementName = "labeledCustomSourceMediaFiles", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22LabeledCustomSourceMediaFiles LabeledCustomSourceMediaFiles {
            get => _labeledCustomSourceMediaFiles;
            set {
                LabeledCustomSourceMediaFilesSpecified = true;
                _labeledCustomSourceMediaFiles = value;
            }
        }

        [XmlIgnore]
        public bool LabeledCustomSourceMediaFilesSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22AnnouncementCustomSourceMediaFiles _announcementCustomSourceMediaFiles;

        [XmlElement(ElementName = "announcementCustomSourceMediaFiles", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22AnnouncementCustomSourceMediaFiles AnnouncementCustomSourceMediaFiles {
            get => _announcementCustomSourceMediaFiles;
            set {
                AnnouncementCustomSourceMediaFilesSpecified = true;
                _announcementCustomSourceMediaFiles = value;
            }
        }

        [XmlIgnore]
        public bool AnnouncementCustomSourceMediaFilesSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22ExternalSource _externalSource;

        [XmlElement(ElementName = "externalSource", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22ExternalSource ExternalSource {
            get => _externalSource;
            set {
                ExternalSourceSpecified = true;
                _externalSource = value;
            }
        }

        [XmlIgnore]
        public bool ExternalSourceSpecified { get; set; }
        
    }
}
