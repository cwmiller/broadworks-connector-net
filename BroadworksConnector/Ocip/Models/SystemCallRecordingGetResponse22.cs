using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallRecordingGetRequest22.
    /// 
    /// Replaced by: SystemCallRecordingGetResponse23
    /// <see cref="SystemCallRecordingGetRequest22"/>
    /// <see cref="SystemCallRecordingGetResponse23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:9299""}]")]
    public class SystemCallRecordingGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _continueCallAfterRecordingFailure;

        [XmlElement(ElementName = "continueCallAfterRecordingFailure", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9299")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:9299")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:9299")]
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

    }
}
