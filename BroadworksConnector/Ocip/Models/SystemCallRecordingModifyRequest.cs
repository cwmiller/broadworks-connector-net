using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Call Recording.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced By: SystemCallRecordingModifyRequest22
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallRecordingModifyRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallRecordingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _continueCallAfterRecordingFailure;

        [XmlElement(ElementName = "continueCallAfterRecordingFailure", IsNullable = false, Namespace = "")]
        public bool ContinueCallAfterRecordingFailure {
            get => _continueCallAfterRecordingFailure;
            set {
                ContinueCallAfterRecordingFailureSpecified = true;
                _continueCallAfterRecordingFailure = value;
            }
        }

        [XmlIgnore]
        public bool ContinueCallAfterRecordingFailureSpecified { get; set; }
        
        private int _refreshPeriodSeconds;

        [XmlElement(ElementName = "refreshPeriodSeconds", IsNullable = false, Namespace = "")]
        public int RefreshPeriodSeconds {
            get => _refreshPeriodSeconds;
            set {
                RefreshPeriodSecondsSpecified = true;
                _refreshPeriodSeconds = value;
            }
        }

        [XmlIgnore]
        public bool RefreshPeriodSecondsSpecified { get; set; }
        
        private int _maxConsecutiveFailures;

        [XmlElement(ElementName = "maxConsecutiveFailures", IsNullable = false, Namespace = "")]
        public int MaxConsecutiveFailures {
            get => _maxConsecutiveFailures;
            set {
                MaxConsecutiveFailuresSpecified = true;
                _maxConsecutiveFailures = value;
            }
        }

        [XmlIgnore]
        public bool MaxConsecutiveFailuresSpecified { get; set; }
        
        private int _maxResponseWaitTimeMilliseconds;

        [XmlElement(ElementName = "maxResponseWaitTimeMilliseconds", IsNullable = false, Namespace = "")]
        public int MaxResponseWaitTimeMilliseconds {
            get => _maxResponseWaitTimeMilliseconds;
            set {
                MaxResponseWaitTimeMillisecondsSpecified = true;
                _maxResponseWaitTimeMilliseconds = value;
            }
        }

        [XmlIgnore]
        public bool MaxResponseWaitTimeMillisecondsSpecified { get; set; }
        
        private bool _continueCallAfterVideoRecordingFailure;

        [XmlElement(ElementName = "continueCallAfterVideoRecordingFailure", IsNullable = false, Namespace = "")]
        public bool ContinueCallAfterVideoRecordingFailure {
            get => _continueCallAfterVideoRecordingFailure;
            set {
                ContinueCallAfterVideoRecordingFailureSpecified = true;
                _continueCallAfterVideoRecordingFailure = value;
            }
        }

        [XmlIgnore]
        public bool ContinueCallAfterVideoRecordingFailureSpecified { get; set; }
        
    }
}
