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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3343"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3346"",""optional"":true}]}]")]
    public class MusicOnHoldSourceRead22V2
    {

        protected BroadWorksConnector.Ocip.Models.AudioFileCodec22 _audioFilePreferredCodec;

        [XmlElement(ElementName = "audioFilePreferredCodec", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3343")]
        public BroadWorksConnector.Ocip.Models.AudioFileCodec22 AudioFilePreferredCodec
        {
            get => _audioFilePreferredCodec;
            set
            {
                AudioFilePreferredCodecSpecified = true;
                _audioFilePreferredCodec = value;
            }
        }

        [XmlIgnore]
        protected bool AudioFilePreferredCodecSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MusicOnHoldMessageSelection _messageSourceSelection;

        [XmlElement(ElementName = "messageSourceSelection", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3343")]
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
        protected bool MessageSourceSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V2LabeledCustomSourceMediaFiles _labeledCustomSourceMediaFiles;

        [XmlElement(ElementName = "labeledCustomSourceMediaFiles", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3346")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V2LabeledCustomSourceMediaFiles LabeledCustomSourceMediaFiles
        {
            get => _labeledCustomSourceMediaFiles;
            set
            {
                LabeledCustomSourceMediaFilesSpecified = true;
                _labeledCustomSourceMediaFiles = value;
            }
        }

        [XmlIgnore]
        protected bool LabeledCustomSourceMediaFilesSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V2AnnouncementCustomSourceMediaFiles _announcementCustomSourceMediaFiles;

        [XmlElement(ElementName = "announcementCustomSourceMediaFiles", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3346")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V2AnnouncementCustomSourceMediaFiles AnnouncementCustomSourceMediaFiles
        {
            get => _announcementCustomSourceMediaFiles;
            set
            {
                AnnouncementCustomSourceMediaFilesSpecified = true;
                _announcementCustomSourceMediaFiles = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementCustomSourceMediaFilesSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V2ExternalSource _externalSource;

        [XmlElement(ElementName = "externalSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3343")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V2ExternalSource ExternalSource
        {
            get => _externalSource;
            set
            {
                ExternalSourceSpecified = true;
                _externalSource = value;
            }
        }

        [XmlIgnore]
        protected bool ExternalSourceSpecified { get; set; }

    }
}
