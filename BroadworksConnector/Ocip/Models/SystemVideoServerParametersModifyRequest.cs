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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19495""}]")]
    public class SystemVideoServerParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _videoServerResponseTimerMilliseconds;

        [XmlElement(ElementName = "videoServerResponseTimerMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:19495")]
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
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:19495")]
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
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:19495")]
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
