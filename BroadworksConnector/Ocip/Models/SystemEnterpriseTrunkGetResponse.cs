using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemEnterpriseTrunkGetRequest.
    /// <see cref="SystemEnterpriseTrunkGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:1680""}]")]
    public class SystemEnterpriseTrunkGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableHoldoverOfHighwaterCallCounts;

        [XmlElement(ElementName = "enableHoldoverOfHighwaterCallCounts", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1680")]
        public bool EnableHoldoverOfHighwaterCallCounts
        {
            get => _enableHoldoverOfHighwaterCallCounts;
            set
            {
                EnableHoldoverOfHighwaterCallCountsSpecified = true;
                _enableHoldoverOfHighwaterCallCounts = value;
            }
        }

        [XmlIgnore]
        protected bool EnableHoldoverOfHighwaterCallCountsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnterpriseTrunkHighwateCallCountHoldoverPeriodMinutes _holdoverPeriod;

        [XmlElement(ElementName = "holdoverPeriod", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1680")]
        public BroadWorksConnector.Ocip.Models.EnterpriseTrunkHighwateCallCountHoldoverPeriodMinutes HoldoverPeriod
        {
            get => _holdoverPeriod;
            set
            {
                HoldoverPeriodSpecified = true;
                _holdoverPeriod = value;
            }
        }

        [XmlIgnore]
        protected bool HoldoverPeriodSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnterpriseTrunkTimeZoneOffsetMinutes _timeZoneOffsetMinutes;

        [XmlElement(ElementName = "timeZoneOffsetMinutes", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1680")]
        public BroadWorksConnector.Ocip.Models.EnterpriseTrunkTimeZoneOffsetMinutes TimeZoneOffsetMinutes
        {
            get => _timeZoneOffsetMinutes;
            set
            {
                TimeZoneOffsetMinutesSpecified = true;
                _timeZoneOffsetMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool TimeZoneOffsetMinutesSpecified { get; set; }

    }
}
