using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Collaborate grace period duration.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:1036""}]")]
    public class CollaborateGracePeriodDuration
    {

        private int _hours;

        [XmlElement(ElementName = "hours", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1036")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1036")]
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
