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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12041""}]")]
    public class SystemMediaServerParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _mediaServerResponseTimerMilliseconds;

        [XmlElement(ElementName = "mediaServerResponseTimerMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12041")]
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

        private int _mediaServerSelectionRouteTimerMilliseconds;

        [XmlElement(ElementName = "mediaServerSelectionRouteTimerMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12041")]
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

        private bool _useStaticMediaServerDevice;

        [XmlElement(ElementName = "useStaticMediaServerDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12041")]
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
