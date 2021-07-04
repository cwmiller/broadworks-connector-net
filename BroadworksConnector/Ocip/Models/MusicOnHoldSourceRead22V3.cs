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
    /// authenticationUserName
    /// The following element is only used in AS data mode:
    /// authenticationRequired, value "false" is returned in XS data mode
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3392"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3395"",""optional"":true}]}]")]
    public class MusicOnHoldSourceRead22V3
    {

        private BroadWorksConnector.Ocip.Models.AudioFileCodec22 _audioFilePreferredCodec;

        [XmlElement(ElementName = "audioFilePreferredCodec", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3392")]
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

        private BroadWorksConnector.Ocip.Models.MusicOnHoldMessageSelection _messageSourceSelection;

        [XmlElement(ElementName = "messageSourceSelection", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3392")]
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

        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V3LabeledCustomSourceMediaFiles _labeledCustomSourceMediaFiles;

        [XmlElement(ElementName = "labeledCustomSourceMediaFiles", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3395")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V3LabeledCustomSourceMediaFiles LabeledCustomSourceMediaFiles
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

        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V3AnnouncementCustomSourceMediaFiles _announcementCustomSourceMediaFiles;

        [XmlElement(ElementName = "announcementCustomSourceMediaFiles", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3395")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V3AnnouncementCustomSourceMediaFiles AnnouncementCustomSourceMediaFiles
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

        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V3ExternalSource _externalSource;

        [XmlElement(ElementName = "externalSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3392")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V3ExternalSource ExternalSource
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
