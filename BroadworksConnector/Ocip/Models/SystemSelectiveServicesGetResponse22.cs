using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSelectiveServicesGetRequest22.
    /// <see cref="SystemSelectiveServicesGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14732""}]")]
    public class SystemSelectiveServicesGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.ScheduleCombinationType _scheduleCombination;

        [XmlElement(ElementName = "scheduleCombination", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14732")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14732")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14732")]
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
