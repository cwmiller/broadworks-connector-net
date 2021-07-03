using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains the music on hold source configuration.
    /// 
    /// Replaced by: MusicOnHoldSourceModify20
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:49134""}]")]
    public class MusicOnHoldSourceModify19sp1
    {

        private BroadWorksConnector.Ocip.Models.AudioFileCodecExtended _audioFilePreferredCodec;

        [XmlElement(ElementName = "audioFilePreferredCodec", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:49134")]
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
        protected bool AudioFilePreferredCodecSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MusicOnHoldMessageSelection _messageSourceSelection;

        [XmlElement(ElementName = "messageSourceSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:49134")]
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

        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceModify19sp1CustomSource _customSource;

        [XmlElement(ElementName = "customSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:49134")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceModify19sp1CustomSource CustomSource
        {
            get => _customSource;
            set
            {
                CustomSourceSpecified = true;
                _customSource = value;
            }
        }

        [XmlIgnore]
        protected bool CustomSourceSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceModify19sp1ExternalSource _externalSource;

        [XmlElement(ElementName = "externalSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:49134")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceModify19sp1ExternalSource ExternalSource
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
