using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSubscriptionLicenseReportingGetRequest.
    /// <see cref="SystemSubscriptionLicenseReportingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18692""}]")]
    public class SystemSubscriptionLicenseReportingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.HourMinute _dailyReportScheduledTime;

        [XmlElement(ElementName = "dailyReportScheduledTime", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18692")]
        public BroadWorksConnector.Ocip.Models.HourMinute DailyReportScheduledTime
        {
            get => _dailyReportScheduledTime;
            set
            {
                DailyReportScheduledTimeSpecified = true;
                _dailyReportScheduledTime = value;
            }
        }

        [XmlIgnore]
        protected bool DailyReportScheduledTimeSpecified { get; set; }

    }
}
