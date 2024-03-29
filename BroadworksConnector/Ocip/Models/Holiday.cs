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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:49858""}]")]
    public class Holiday
    {

        protected string _holidayName;

        [XmlElement(ElementName = "holidayName", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:49858")]
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

        protected string _startDate;

        [XmlElement(ElementName = "startDate", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:49858")]
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

        protected string _endDate;

        [XmlElement(ElementName = "endDate", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:49858")]
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
