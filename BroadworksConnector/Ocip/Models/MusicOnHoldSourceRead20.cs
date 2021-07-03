using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains the music on hold source configuration.
    /// Replaced by: MusicOnHoldSourceRead21
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:14933""}]")]
    public class MusicOnHoldSourceRead20
    {

        private BroadWorksConnector.Ocip.Models.AudioFileCodec _audioFilePreferredCodec;

        [XmlElement(ElementName = "audioFilePreferredCodec", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:14933")]
        public BroadWorksConnector.Ocip.Models.AudioFileCodec AudioFilePreferredCodec
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:14933")]
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

        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead20CustomSource _customSource;

        [XmlElement(ElementName = "customSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:14933")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead20CustomSource CustomSource
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

        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead20ExternalSource _externalSource;

        [XmlElement(ElementName = "externalSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:14933")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead20ExternalSource ExternalSource
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
