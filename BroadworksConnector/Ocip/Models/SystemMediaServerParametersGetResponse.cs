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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12023""}]")]
    public class SystemMediaServerParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _mediaServerResponseTimerMilliseconds;

        [XmlElement(ElementName = "mediaServerResponseTimerMilliseconds", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12023")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12023")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12023")]
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
