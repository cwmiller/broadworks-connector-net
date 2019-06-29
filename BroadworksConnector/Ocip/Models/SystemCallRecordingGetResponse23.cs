using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallRecordingGetRequest23.
    /// <see cref="SystemCallRecordingGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9741e074fbfeb4c7312bfa4dfbaee3d3:291""}]")]
    public class SystemCallRecordingGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _continueCallAfterRecordingFailure;

        [XmlElement(ElementName = "continueCallAfterRecordingFailure", IsNullable = false, Namespace = "")]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:291")]
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

        private int _maxResponseWaitTimeMilliseconds;

        [XmlElement(ElementName = "maxResponseWaitTimeMilliseconds", IsNullable = false, Namespace = "")]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:291")]
        [MinInclusive(1000)]
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

        private bool _continueCallAfterVideoRecordingFailure;

        [XmlElement(ElementName = "continueCallAfterVideoRecordingFailure", IsNullable = false, Namespace = "")]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:291")]
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

        private bool _useContinueCallAfterRecordingFailureForOnDemandMode;

        [XmlElement(ElementName = "useContinueCallAfterRecordingFailureForOnDemandMode", IsNullable = false, Namespace = "")]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:291")]
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

        private bool _useContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartMode;

        [XmlElement(ElementName = "useContinueCallAfterRecordingFailureForOnDemandUserInitiatedStartMode", IsNullable = false, Namespace = "")]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:291")]
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

        private bool _restrictCallRecordingProvisioningAccess;

        [XmlElement(ElementName = "restrictCallRecordingProvisioningAccess", IsNullable = false, Namespace = "")]
        [Group(@"9741e074fbfeb4c7312bfa4dfbaee3d3:291")]
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
