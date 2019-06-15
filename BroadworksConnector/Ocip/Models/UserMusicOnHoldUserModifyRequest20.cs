using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify data for Music On Hold User.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserMusicOnHoldUserModifyRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceModify20 _source;

        [XmlElement(ElementName = "source", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceModify20 Source {
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
        
        private BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceModify20 _internalSource;

        [XmlElement(ElementName = "internalSource", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceModify20 InternalSource {
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
