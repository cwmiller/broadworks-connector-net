using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Network Device Polling system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12632""}]")]
    public class SystemNetworkDeviceMonitorParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private int _pollingIntervalMinutes;

        [XmlElement(ElementName = "pollingIntervalMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12632")]
        [MinInclusive(0)]
        [MaxInclusive(1440)]
        public int PollingIntervalMinutes
        {
            get => _pollingIntervalMinutes;
            set
            {
                PollingIntervalMinutesSpecified = true;
                _pollingIntervalMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool PollingIntervalMinutesSpecified { get; set; }

        private int _failedPollingIntervalMinutes;

        [XmlElement(ElementName = "failedPollingIntervalMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12632")]
        [MinInclusive(1)]
        [MaxInclusive(720)]
        public int FailedPollingIntervalMinutes
        {
            get => _failedPollingIntervalMinutes;
            set
            {
                FailedPollingIntervalMinutesSpecified = true;
                _failedPollingIntervalMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool FailedPollingIntervalMinutesSpecified { get; set; }

    }
}
