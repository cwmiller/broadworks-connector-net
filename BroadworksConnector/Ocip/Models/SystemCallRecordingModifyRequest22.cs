using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Call Recording.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// continueCallAfterRecordingFailure
    /// maxResponseWaitTimeMilliseconds
    /// continueCallAfterVideoRecordingFailure
    /// useContinueCallAfterRecordingFailureForOnDemandMode
    /// useContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartMode
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="maxResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0731150ec7515df8cd710f04d8f62f66:416""}]")]
    public class SystemCallRecordingModifyRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _continueCallAfterRecordingFailure;

        [XmlElement(ElementName = "continueCallAfterRecordingFailure", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0731150ec7515df8cd710f04d8f62f66:416")]
        public bool ContinueCallAfterRecordingFailure
        {
            get => _continueCallAfterRecordingFailure;
            set
            {
                ContinueCallAfterRecordingFailureSpecified = true;
                _continueCallAfterRecordingFailure = value;
            }
        }

        [XmlIgnore]
        protected bool ContinueCallAfterRecordingFailureSpecified { get; set; }

        protected int _maxResponseWaitTimeMilliseconds;

        [XmlElement(ElementName = "maxResponseWaitTimeMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0731150ec7515df8cd710f04d8f62f66:416")]
        [MinInclusive(50)]
        [MaxInclusive(10000)]
        public int MaxResponseWaitTimeMilliseconds
        {
            get => _maxResponseWaitTimeMilliseconds;
            set
            {
                MaxResponseWaitTimeMillisecondsSpecified = true;
                _maxResponseWaitTimeMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool MaxResponseWaitTimeMillisecondsSpecified { get; set; }

        protected bool _continueCallAfterVideoRecordingFailure;

        [XmlElement(ElementName = "continueCallAfterVideoRecordingFailure", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0731150ec7515df8cd710f04d8f62f66:416")]
        public bool ContinueCallAfterVideoRecordingFailure
        {
            get => _continueCallAfterVideoRecordingFailure;
            set
            {
                ContinueCallAfterVideoRecordingFailureSpecified = true;
                _continueCallAfterVideoRecordingFailure = value;
            }
        }

        [XmlIgnore]
        protected bool ContinueCallAfterVideoRecordingFailureSpecified { get; set; }

        protected bool _useContinueCallAfterRecordingFailureForOnDemandMode;

        [XmlElement(ElementName = "useContinueCallAfterRecordingFailureForOnDemandMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0731150ec7515df8cd710f04d8f62f66:416")]
        public bool UseContinueCallAfterRecordingFailureForOnDemandMode
        {
            get => _useContinueCallAfterRecordingFailureForOnDemandMode;
            set
            {
                UseContinueCallAfterRecordingFailureForOnDemandModeSpecified = true;
                _useContinueCallAfterRecordingFailureForOnDemandMode = value;
            }
        }

        [XmlIgnore]
        protected bool UseContinueCallAfterRecordingFailureForOnDemandModeSpecified { get; set; }

        protected bool _useContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartMode;

        [XmlElement(ElementName = "useContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0731150ec7515df8cd710f04d8f62f66:416")]
        public bool UseContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartMode
        {
            get => _useContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartMode;
            set
            {
                UseContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartModeSpecified = true;
                _useContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartMode = value;
            }
        }

        [XmlIgnore]
        protected bool UseContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartModeSpecified { get; set; }

        protected bool _restrictCallRecordingProvisioningAccess;

        [XmlElement(ElementName = "restrictCallRecordingProvisioningAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0731150ec7515df8cd710f04d8f62f66:416")]
        public bool RestrictCallRecordingProvisioningAccess
        {
            get => _restrictCallRecordingProvisioningAccess;
            set
            {
                RestrictCallRecordingProvisioningAccessSpecified = true;
                _restrictCallRecordingProvisioningAccess = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictCallRecordingProvisioningAccessSpecified { get; set; }

    }
}
