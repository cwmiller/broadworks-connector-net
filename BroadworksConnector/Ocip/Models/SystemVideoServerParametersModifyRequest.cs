using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify video server system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18187""}]")]
    public class SystemVideoServerParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _videoServerResponseTimerMilliseconds;

        [XmlElement(ElementName = "videoServerResponseTimerMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18187")]
        [MinInclusive(600)]
        [MaxInclusive(120000)]
        public int VideoServerResponseTimerMilliseconds
        {
            get => _videoServerResponseTimerMilliseconds;
            set
            {
                VideoServerResponseTimerMillisecondsSpecified = true;
                _videoServerResponseTimerMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool VideoServerResponseTimerMillisecondsSpecified { get; set; }

        private int _videoServerSelectionRouteTimerMilliseconds;

        [XmlElement(ElementName = "videoServerSelectionRouteTimerMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18187")]
        [MinInclusive(500)]
        [MaxInclusive(120000)]
        public int VideoServerSelectionRouteTimerMilliseconds
        {
            get => _videoServerSelectionRouteTimerMilliseconds;
            set
            {
                VideoServerSelectionRouteTimerMillisecondsSpecified = true;
                _videoServerSelectionRouteTimerMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool VideoServerSelectionRouteTimerMillisecondsSpecified { get; set; }

        private bool _useStaticVideoServerDevice;

        [XmlElement(ElementName = "useStaticVideoServerDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18187")]
        public bool UseStaticVideoServerDevice
        {
            get => _useStaticVideoServerDevice;
            set
            {
                UseStaticVideoServerDeviceSpecified = true;
                _useStaticVideoServerDevice = value;
            }
        }

        [XmlIgnore]
        protected bool UseStaticVideoServerDeviceSpecified { get; set; }

    }
}
