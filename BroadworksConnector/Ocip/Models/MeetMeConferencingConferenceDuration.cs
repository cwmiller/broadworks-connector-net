using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Conference duration.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""adf25df72505d1c476ebb480b6cce18d:945""}]")]
    public class MeetMeConferencingConferenceDuration
    {

        protected int _hours;

        [XmlElement(ElementName = "hours", IsNullable = false, Namespace = "")]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:945")]
        [MinInclusive(0)]
        [MaxInclusive(23)]
        public int Hours
        {
            get => _hours;
            set
            {
                HoursSpecified = true;
                _hours = value;
            }
        }

        [XmlIgnore]
        protected bool HoursSpecified { get; set; }

        protected int _minutes;

        [XmlElement(ElementName = "minutes", IsNullable = false, Namespace = "")]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:945")]
        [RegularExpression(@"0|15|30|45")]
        public int Minutes
        {
            get => _minutes;
            set
            {
                MinutesSpecified = true;
                _minutes = value;
            }
        }

        [XmlIgnore]
        protected bool MinutesSpecified { get; set; }

    }
}
