using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2750"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2753"",""optional"":true}]}]")]
    public class MusicOnHoldSourceRead21
    {

        private BroadWorksConnector.Ocip.Models.AudioFileCodecExtended _audioFilePreferredCodec;

        [XmlElement(ElementName = "audioFilePreferredCodec", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2750")]
        public BroadWorksConnector.Ocip.Models.AudioFileCodecExtended AudioFilePreferredCodec
        {
            get => _audioFilePreferredCodec;
            set
            {
                AudioFilePreferredCodecSpecified = true;
                _audioFilePreferredCodec = value;
            }
        }

        [XmlIgnore]
        public bool AudioFilePreferredCodecSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MusicOnHoldMessageSelection _messageSourceSelection;

        [XmlElement(ElementName = "messageSourceSelection", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2750")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldMessageSelection MessageSourceSelection
        {
            get => _messageSourceSelection;
            set
            {
                MessageSourceSelectionSpecified = true;
                _messageSourceSelection = value;
            }
        }

        [XmlIgnore]
        public bool MessageSourceSelectionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead21LabeledCustomSourceMediaFiles _labeledCustomSourceMediaFiles;

        [XmlElement(ElementName = "labeledCustomSourceMediaFiles", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2753")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead21LabeledCustomSourceMediaFiles LabeledCustomSourceMediaFiles
        {
            get => _labeledCustomSourceMediaFiles;
            set
            {
                LabeledCustomSourceMediaFilesSpecified = true;
                _labeledCustomSourceMediaFiles = value;
            }
        }

        [XmlIgnore]
        public bool LabeledCustomSourceMediaFilesSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead21AnnouncementCustomSourceMediaFiles _announcementCustomSourceMediaFiles;

        [XmlElement(ElementName = "announcementCustomSourceMediaFiles", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2753")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead21AnnouncementCustomSourceMediaFiles AnnouncementCustomSourceMediaFiles
        {
            get => _announcementCustomSourceMediaFiles;
            set
            {
                AnnouncementCustomSourceMediaFilesSpecified = true;
                _announcementCustomSourceMediaFiles = value;
            }
        }

        [XmlIgnore]
        public bool AnnouncementCustomSourceMediaFilesSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead21ExternalSource _externalSource;

        [XmlElement(ElementName = "externalSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2750")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead21ExternalSource ExternalSource
        {
            get => _externalSource;
            set
            {
                ExternalSourceSpecified = true;
                _externalSource = value;
            }
        }

        [XmlIgnore]
        public bool ExternalSourceSpecified { get; set; }

    }
}
