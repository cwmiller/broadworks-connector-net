using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemVideoServerParametersGetRequest.
    /// Contains a list of system video server parameters.
    /// <see cref="SystemVideoServerParametersGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18169""}]")]
    public class SystemVideoServerParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _videoServerResponseTimerMilliseconds;

        [XmlElement(ElementName = "videoServerResponseTimerMilliseconds", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18169")]
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
        public bool VideoServerResponseTimerMillisecondsSpecified { get; set; }

        private int _videoServerSelectionRouteTimerMilliseconds;

        [XmlElement(ElementName = "videoServerSelectionRouteTimerMilliseconds", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18169")]
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
        public bool VideoServerSelectionRouteTimerMillisecondsSpecified { get; set; }

        private bool _useStaticVideoServerDevice;

        [XmlElement(ElementName = "useStaticVideoServerDevice", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18169")]
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
        public bool UseStaticVideoServerDeviceSpecified { get; set; }

    }
}
