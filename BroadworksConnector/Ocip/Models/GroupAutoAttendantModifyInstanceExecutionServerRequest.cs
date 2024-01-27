using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify an Auto Attendant instance.
    /// Only Group and Enterprise level schedules are accepted.
    /// The response is either SuccessResponse or ErrorResponse.
    /// Engineering Note: This command can only be executed from the Execution Server
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0b10bca40a55275de6ba2076c583b7fd:46""}]")]
    public class GroupAutoAttendantModifyInstanceExecutionServerRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"0b10bca40a55275de6ba2076c583b7fd:46")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenuExecutionServer _businessHoursMenu;

        [XmlElement(ElementName = "businessHoursMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0b10bca40a55275de6ba2076c583b7fd:46")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenuExecutionServer BusinessHoursMenu
        {
            get => _businessHoursMenu;
            set
            {
                BusinessHoursMenuSpecified = true;
                _businessHoursMenu = value;
            }
        }

        [XmlIgnore]
        protected bool BusinessHoursMenuSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenuExecutionServer _afterHoursMenu;

        [XmlElement(ElementName = "afterHoursMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0b10bca40a55275de6ba2076c583b7fd:46")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenuExecutionServer AfterHoursMenu
        {
            get => _afterHoursMenu;
            set
            {
                AfterHoursMenuSpecified = true;
                _afterHoursMenu = value;
            }
        }

        [XmlIgnore]
        protected bool AfterHoursMenuSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenuExecutionServer _holidayMenu;

        [XmlElement(ElementName = "holidayMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0b10bca40a55275de6ba2076c583b7fd:46")]
        public BroadWorksConnector.Ocip.Models.AutoAttendantModifyMenuExecutionServer HolidayMenu
        {
            get => _holidayMenu;
            set
            {
                HolidayMenuSpecified = true;
                _holidayMenu = value;
            }
        }

        [XmlIgnore]
        protected bool HolidayMenuSpecified { get; set; }

    }
}
