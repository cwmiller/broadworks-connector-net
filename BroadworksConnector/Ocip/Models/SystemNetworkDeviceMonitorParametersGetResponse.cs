using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemNetworkDeviceMonitorParametersGetListRequest.
    /// Contains a list of system Network Device Polling parameters.
    /// <see cref="SystemNetworkDeviceMonitorParametersGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12785""}]")]
    public class SystemNetworkDeviceMonitorParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _pollingIntervalMinutes;

        [XmlElement(ElementName = "pollingIntervalMinutes", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12785")]
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

        protected int _failedPollingIntervalMinutes;

        [XmlElement(ElementName = "failedPollingIntervalMinutes", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12785")]
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
