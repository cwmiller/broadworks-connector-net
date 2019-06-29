using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserGroupNightForwardingGetRequest.
    /// businessHours and holidaySchedule are returned in the response only when groupNightForwarding is ‘Auto On’.
    /// <see cref="UserGroupNightForwardingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1a3849774e8d2ffd90c3a2c57cbdd7a0:164""}]")]
    public class UserGroupNightForwardingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.GroupNightForwardingUserServiceActivationMode _nightForwarding;

        [XmlElement(ElementName = "nightForwarding", IsNullable = false, Namespace = "")]
        [Group(@"1a3849774e8d2ffd90c3a2c57cbdd7a0:164")]
        public BroadWorksConnector.Ocip.Models.GroupNightForwardingUserServiceActivationMode NightForwarding
        {
            get => _nightForwarding;
            set
            {
                NightForwardingSpecified = true;
                _nightForwarding = value;
            }
        }

        [XmlIgnore]
        protected bool NightForwardingSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupNightForwardingGroupServiceActivationMode _groupNightForwarding;

        [XmlElement(ElementName = "groupNightForwarding", IsNullable = false, Namespace = "")]
        [Group(@"1a3849774e8d2ffd90c3a2c57cbdd7a0:164")]
        public BroadWorksConnector.Ocip.Models.GroupNightForwardingGroupServiceActivationMode GroupNightForwarding
        {
            get => _groupNightForwarding;
            set
            {
                GroupNightForwardingSpecified = true;
                _groupNightForwarding = value;
            }
        }

        [XmlIgnore]
        protected bool GroupNightForwardingSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeSchedule _businessHours;

        [XmlElement(ElementName = "businessHours", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1a3849774e8d2ffd90c3a2c57cbdd7a0:164")]
        public BroadWorksConnector.Ocip.Models.TimeSchedule BusinessHours
        {
            get => _businessHours;
            set
            {
                BusinessHoursSpecified = true;
                _businessHours = value;
            }
        }

        [XmlIgnore]
        protected bool BusinessHoursSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1a3849774e8d2ffd90c3a2c57cbdd7a0:164")]
        public BroadWorksConnector.Ocip.Models.HolidaySchedule HolidaySchedule
        {
            get => _holidaySchedule;
            set
            {
                HolidayScheduleSpecified = true;
                _holidaySchedule = value;
            }
        }

        [XmlIgnore]
        protected bool HolidayScheduleSpecified { get; set; }

    }
}
