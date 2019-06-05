using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallCenterMusicOnHoldSourceModify
    {
        private BroadworksConnector.Ocip.Models.AudioFileCodec _audioFilePreferredCodec;

        [XmlElement(ElementName = "audioFilePreferredCodec", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AudioFileCodec AudioFilePreferredCodec
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
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementSelection _messageSourceSelection;

        [XmlElement(ElementName = "messageSourceSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementSelection MessageSourceSelection
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
        private BroadworksConnector.Ocip.Models.CallCenterMusicOnHoldSourceModifyCustomSource _customSource;

        [XmlElement(ElementName = "customSource", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterMusicOnHoldSourceModifyCustomSource CustomSource
        {
            get => _customSource;
            set
            {
                CustomSourceSpecified = true;
                _customSource = value;
            }
        }

        [XmlIgnore]
        public bool CustomSourceSpecified { get; set; }
    }
}
