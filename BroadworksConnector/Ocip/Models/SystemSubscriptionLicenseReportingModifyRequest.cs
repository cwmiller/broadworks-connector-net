using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the subscription license reporting system parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18708""}]")]
    public class SystemSubscriptionLicenseReportingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected BroadWorksConnector.Ocip.Models.HourMinute _dailyReportScheduledTime;

        [XmlElement(ElementName = "dailyReportScheduledTime", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18708")]
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
