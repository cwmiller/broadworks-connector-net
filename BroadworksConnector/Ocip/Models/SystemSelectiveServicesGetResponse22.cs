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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16090""}]")]
    public class SystemSelectiveServicesGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.ScheduleCombinationType _scheduleCombination;

        [XmlElement(ElementName = "scheduleCombination", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:16090")]
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

        protected bool _screenPrivateNumber;

        [XmlElement(ElementName = "screenPrivateNumber", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:16090")]
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

        protected bool _emptyHolidayScheduleIsOutOfSchedule;

        [XmlElement(ElementName = "emptyHolidayScheduleIsOutOfSchedule", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:16090")]
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
