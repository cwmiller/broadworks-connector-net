using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with SystemSelectiveServicesRequest.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SystemSelectiveServicesRequest"/>
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14750""}]")]
    public class SystemSelectiveServicesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.ScheduleCombinationType _scheduleCombination;

        [XmlElement(ElementName = "scheduleCombination", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14750")]
        public BroadWorksConnector.Ocip.Models.ScheduleCombinationType ScheduleCombination
        {
            get => _scheduleCombination;
            set
            {
                ScheduleCombinationSpecified = true;
                _scheduleCombination = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleCombinationSpecified { get; set; }

        private bool _screenPrivateNumber;

        [XmlElement(ElementName = "screenPrivateNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14750")]
        public bool ScreenPrivateNumber
        {
            get => _screenPrivateNumber;
            set
            {
                ScreenPrivateNumberSpecified = true;
                _screenPrivateNumber = value;
            }
        }

        [XmlIgnore]
        protected bool ScreenPrivateNumberSpecified { get; set; }

        private bool _emptyHolidayScheduleIsOutOfSchedule;

        [XmlElement(ElementName = "emptyHolidayScheduleIsOutOfSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14750")]
        public bool EmptyHolidayScheduleIsOutOfSchedule
        {
            get => _emptyHolidayScheduleIsOutOfSchedule;
            set
            {
                EmptyHolidayScheduleIsOutOfScheduleSpecified = true;
                _emptyHolidayScheduleIsOutOfSchedule = value;
            }
        }

        [XmlIgnore]
        protected bool EmptyHolidayScheduleIsOutOfScheduleSpecified { get; set; }

    }
}
