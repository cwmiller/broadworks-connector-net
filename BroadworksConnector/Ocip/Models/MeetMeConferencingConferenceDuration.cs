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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:1030""}]")]
    public class MeetMeConferencingConferenceDuration
    {

        private int _hours;

        [XmlElement(ElementName = "hours", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:1030")]
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
        public bool HoursSpecified { get; set; }

        private int _minutes;

        [XmlElement(ElementName = "minutes", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:1030")]
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
        public bool MinutesSpecified { get; set; }

    }
}
