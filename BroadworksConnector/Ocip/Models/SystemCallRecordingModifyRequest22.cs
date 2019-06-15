using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Call Recording.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallRecordingModifyRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private bool _useContinueCallAfterRecordingFailureForOnDemandMode;

        [XmlElement(ElementName = "useContinueCallAfterRecordingFailureForOnDemandMode", IsNullable = false, Namespace = "")]
        public bool UseContinueCallAfterRecordingFailureForOnDemandMode {
            get => _useContinueCallAfterRecordingFailureForOnDemandMode;
            set {
                UseContinueCallAfterRecordingFailureForOnDemandModeSpecified = true;
                _useContinueCallAfterRecordingFailureForOnDemandMode = value;
            }
        }

        [XmlIgnore]
        public bool UseContinueCallAfterRecordingFailureForOnDemandModeSpecified { get; set; }
        
        private bool _useContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartMode;

        [XmlElement(ElementName = "useContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartMode", IsNullable = false, Namespace = "")]
        public bool UseContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartMode {
            get => _useContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartMode;
            set {
                UseContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartModeSpecified = true;
                _useContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartMode = value;
            }
        }

        [XmlIgnore]
        public bool UseContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartModeSpecified { get; set; }
        
        private bool _restrictCallRecordingProvisioningAccess;

        [XmlElement(ElementName = "restrictCallRecordingProvisioningAccess", IsNullable = false, Namespace = "")]
        public bool RestrictCallRecordingProvisioningAccess {
            get => _restrictCallRecordingProvisioningAccess;
            set {
                RestrictCallRecordingProvisioningAccessSpecified = true;
                _restrictCallRecordingProvisioningAccess = value;
            }
        }

        [XmlIgnore]
        public bool RestrictCallRecordingProvisioningAccessSpecified { get; set; }
        
    }
}
