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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19477""}]")]
    public class SystemVideoServerParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _videoServerResponseTimerMilliseconds;

        [XmlElement(ElementName = "videoServerResponseTimerMilliseconds", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:19477")]
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

        protected int _videoServerSelectionRouteTimerMilliseconds;

        [XmlElement(ElementName = "videoServerSelectionRouteTimerMilliseconds", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:19477")]
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

        protected bool _useStaticVideoServerDevice;

        [XmlElement(ElementName = "useStaticVideoServerDevice", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:19477")]
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
