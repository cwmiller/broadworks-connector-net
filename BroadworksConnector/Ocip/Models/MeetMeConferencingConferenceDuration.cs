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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:945""}]")]
    public class MeetMeConferencingConferenceDuration
    {

        private int _hours;

        [XmlElement(ElementName = "hours", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:945")]
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

        private int _minutes;

        [XmlElement(ElementName = "minutes", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:945")]
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
