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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""65f35694d7d3354987bf6387ab55bfc6:164""}]")]
    public class UserGroupNightForwardingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.GroupNightForwardingUserServiceActivationMode _nightForwarding;

        [XmlElement(ElementName = "nightForwarding", IsNullable = false, Namespace = "")]
        [Group(@"65f35694d7d3354987bf6387ab55bfc6:164")]
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

        protected BroadWorksConnector.Ocip.Models.GroupNightForwardingGroupServiceActivationMode _groupNightForwarding;

        [XmlElement(ElementName = "groupNightForwarding", IsNullable = false, Namespace = "")]
        [Group(@"65f35694d7d3354987bf6387ab55bfc6:164")]
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

        protected BroadWorksConnector.Ocip.Models.TimeSchedule _businessHours;

        [XmlElement(ElementName = "businessHours", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"65f35694d7d3354987bf6387ab55bfc6:164")]
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

        protected BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"65f35694d7d3354987bf6387ab55bfc6:164")]
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
