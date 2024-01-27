using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccessDeviceMonitorParametersGetListRequest.
    /// Contains a list of system Access Device Monitor parameters.
    /// <see cref="SystemAccessDeviceMonitorParametersGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:1679""}]")]
    public class SystemAccessDeviceMonitorParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _pollingIntervalMinutes;

        [XmlElement(ElementName = "pollingIntervalMinutes", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:1679")]
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

    }
}
