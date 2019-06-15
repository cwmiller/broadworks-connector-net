using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserMusicOnHoldUserGetRequest.
    /// Replaced By: UserMusicOnHoldUserGetResponse16
        /// <see cref="UserMusicOnHoldUserGetRequest"/>
        /// <see cref="UserMusicOnHoldUserGetResponse16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserMusicOnHoldUserGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        public bool EnableVideo {
            get => _enableVideo;
            set {
                EnableVideoSpecified = true;
                _enableVideo = value;
            }
        }

        [XmlIgnore]
        public bool EnableVideoSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead _source;

        [XmlElement(ElementName = "source", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead Source {
            get => _source;
            set {
                SourceSpecified = true;
                _source = value;
            }
        }

        [XmlIgnore]
        public bool SourceSpecified { get; set; }
        
        private bool _useAlternateSourceForInternalCalls;

        [XmlElement(ElementName = "useAlternateSourceForInternalCalls", IsNullable = false, Namespace = "")]
        public bool UseAlternateSourceForInternalCalls {
            get => _useAlternateSourceForInternalCalls;
            set {
                UseAlternateSourceForInternalCallsSpecified = true;
                _useAlternateSourceForInternalCalls = value;
            }
        }

        [XmlIgnore]
        public bool UseAlternateSourceForInternalCallsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead _internalSource;

        [XmlElement(ElementName = "internalSource", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead InternalSource {
            get => _internalSource;
            set {
                InternalSourceSpecified = true;
                _internalSource = value;
            }
        }

        [XmlIgnore]
        public bool InternalSourceSpecified { get; set; }
        
    }
}
