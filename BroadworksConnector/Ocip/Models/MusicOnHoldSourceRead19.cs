using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains the music on hold source configuration.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class MusicOnHoldSourceRead19 
    {

        
        private BroadWorksConnector.Ocip.Models.AudioFileCodec _audioFilePreferredCodec;

        [XmlElement(ElementName = "audioFilePreferredCodec", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AudioFileCodec AudioFilePreferredCodec {
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
        
        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead19CustomSource _customSource;

        [XmlElement(ElementName = "customSource", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead19CustomSource CustomSource {
            get => _customSource;
            set {
                CustomSourceSpecified = true;
                _customSource = value;
            }
        }

        [XmlIgnore]
        public bool CustomSourceSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead19ExternalSource _externalSource;

        [XmlElement(ElementName = "externalSource", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead19ExternalSource ExternalSource {
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
