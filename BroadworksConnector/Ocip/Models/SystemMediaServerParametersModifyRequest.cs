using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Media Server system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12163""}]")]
    public class SystemMediaServerParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _mediaServerResponseTimerMilliseconds;

        [XmlElement(ElementName = "mediaServerResponseTimerMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12163")]
        [MinInclusive(600)]
        [MaxInclusive(120000)]
        public int MediaServerResponseTimerMilliseconds
        {
            get => _mediaServerResponseTimerMilliseconds;
            set
            {
                MediaServerResponseTimerMillisecondsSpecified = true;
                _mediaServerResponseTimerMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool MediaServerResponseTimerMillisecondsSpecified { get; set; }

        protected int _mediaServerSelectionRouteTimerMilliseconds;

        [XmlElement(ElementName = "mediaServerSelectionRouteTimerMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12163")]
        [MinInclusive(500)]
        [MaxInclusive(120000)]
        public int MediaServerSelectionRouteTimerMilliseconds
        {
            get => _mediaServerSelectionRouteTimerMilliseconds;
            set
            {
                MediaServerSelectionRouteTimerMillisecondsSpecified = true;
                _mediaServerSelectionRouteTimerMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool MediaServerSelectionRouteTimerMillisecondsSpecified { get; set; }

        protected bool _useStaticMediaServerDevice;

        [XmlElement(ElementName = "useStaticMediaServerDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:12163")]
        public bool UseStaticMediaServerDevice
        {
            get => _useStaticMediaServerDevice;
            set
            {
                UseStaticMediaServerDeviceSpecified = true;
                _useStaticMediaServerDevice = value;
            }
        }

        [XmlIgnore]
        protected bool UseStaticMediaServerDeviceSpecified { get; set; }

    }
}
