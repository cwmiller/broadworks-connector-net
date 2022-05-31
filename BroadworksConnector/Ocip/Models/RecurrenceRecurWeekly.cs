using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3623""}]")]
    public class RecurrenceRecurWeekly
    {

        protected int _recurInterval;

        [XmlElement(ElementName = "recurInterval", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3623")]
        [MinInclusive(1)]
        [MaxInclusive(999)]
        public int RecurInterval
        {
            get => _recurInterval;
            set
            {
                RecurIntervalSpecified = true;
                _recurInterval = value;
            }
        }

        [XmlIgnore]
        protected bool RecurIntervalSpecified { get; set; }

        protected bool _sunday;

        [XmlElement(ElementName = "sunday", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3623")]
        public bool Sunday
        {
            get => _sunday;
            set
            {
                SundaySpecified = true;
                _sunday = value;
            }
        }

        [XmlIgnore]
        protected bool SundaySpecified { get; set; }

        protected bool _monday;

        [XmlElement(ElementName = "monday", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3623")]
        public bool Monday
        {
            get => _monday;
            set
            {
                MondaySpecified = true;
                _monday = value;
            }
        }

        [XmlIgnore]
        protected bool MondaySpecified { get; set; }

        protected bool _tuesday;

        [XmlElement(ElementName = "tuesday", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3623")]
        public bool Tuesday
        {
            get => _tuesday;
            set
            {
                TuesdaySpecified = true;
                _tuesday = value;
            }
        }

        [XmlIgnore]
        protected bool TuesdaySpecified { get; set; }

        protected bool _wednesday;

        [XmlElement(ElementName = "wednesday", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3623")]
        public bool Wednesday
        {
            get => _wednesday;
            set
            {
                WednesdaySpecified = true;
                _wednesday = value;
            }
        }

        [XmlIgnore]
        protected bool WednesdaySpecified { get; set; }

        protected bool _thursday;

        [XmlElement(ElementName = "thursday", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3623")]
        public bool Thursday
        {
            get => _thursday;
            set
            {
                ThursdaySpecified = true;
                _thursday = value;
            }
        }

        [XmlIgnore]
        protected bool ThursdaySpecified { get; set; }

        protected bool _friday;

        [XmlElement(ElementName = "friday", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3623")]
        public bool Friday
        {
            get => _friday;
            set
            {
                FridaySpecified = true;
                _friday = value;
            }
        }

        [XmlIgnore]
        protected bool FridaySpecified { get; set; }

        protected bool _saturday;

        [XmlElement(ElementName = "saturday", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3623")]
        public bool Saturday
        {
            get => _saturday;
            set
            {
                SaturdaySpecified = true;
                _saturday = value;
            }
        }

        [XmlIgnore]
        protected bool SaturdaySpecified { get; set; }

    }
}
