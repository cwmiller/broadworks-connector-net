using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallRecordingGetRequest23.
    /// 
    /// The following elements are only used in AS data mode:
    /// continueCallAfterRecordingFailure, value "false" is returned in XS data mode
    /// maxResponseWaitTimeMilliseconds, value "50" is returned in XS data mode
    /// continueCallAfterVideoRecordingFailure, value "false" is returned in XS data mode
    /// useContinueCallAfterRecordingFailureForOnDemandMode, value "false" is returned in XS data mode
    /// useContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartMode, value "false" is returned in XS data mode
    /// <see cref="SystemCallRecordingGetRequest23"/>
    /// <see cref="maxResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0731150ec7515df8cd710f04d8f62f66:356""}]")]
    public class SystemCallRecordingGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _continueCallAfterRecordingFailure;

        [XmlElement(ElementName = "continueCallAfterRecordingFailure", IsNullable = false, Namespace = "")]
        [Group(@"0731150ec7515df8cd710f04d8f62f66:356")]
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
        [Group(@"0731150ec7515df8cd710f04d8f62f66:356")]
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
        [Group(@"0731150ec7515df8cd710f04d8f62f66:356")]
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
        [Group(@"0731150ec7515df8cd710f04d8f62f66:356")]
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
        [Group(@"0731150ec7515df8cd710f04d8f62f66:356")]
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
        [Group(@"0731150ec7515df8cd710f04d8f62f66:356")]
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
