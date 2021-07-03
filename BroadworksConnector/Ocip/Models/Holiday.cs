using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Holiday entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:48972""}]")]
    public class Holiday
    {

        private string _holidayName;

        [XmlElement(ElementName = "holidayName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48972")]
        [MinLength(1)]
        [MaxLength(40)]
        public string HolidayName
        {
            get => _holidayName;
            set
            {
                HolidayNameSpecified = true;
                _holidayName = value;
            }
        }

        [XmlIgnore]
        protected bool HolidayNameSpecified { get; set; }

        private string _startDate;

        [XmlElement(ElementName = "startDate", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48972")]
        public string StartDate
        {
            get => _startDate;
            set
            {
                StartDateSpecified = true;
                _startDate = value;
            }
        }

        [XmlIgnore]
        protected bool StartDateSpecified { get; set; }

        private string _endDate;

        [XmlElement(ElementName = "endDate", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48972")]
        public string EndDate
        {
            get => _endDate;
            set
            {
                EndDateSpecified = true;
                _endDate = value;
            }
        }

        [XmlIgnore]
        protected bool EndDateSpecified { get; set; }

    }
}
