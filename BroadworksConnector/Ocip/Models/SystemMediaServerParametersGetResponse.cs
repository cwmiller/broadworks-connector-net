using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMediaServerParametersGetListRequest.
    /// Contains a list of system Media Server parameters.
    /// <see cref="SystemMediaServerParametersGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12145""}]")]
    public class SystemMediaServerParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _mediaServerResponseTimerMilliseconds;

        [XmlElement(ElementName = "mediaServerResponseTimerMilliseconds", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12145")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:12145")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:12145")]
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
