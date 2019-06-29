using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Time range used to filter call logs.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2178""}]")]
    public class EnhancedCallLogsTimeRange
    {

        private string _startDateTime;

        [XmlElement(ElementName = "startDateTime", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2178")]
        public string StartDateTime
        {
            get => _startDateTime;
            set
            {
                StartDateTimeSpecified = true;
                _startDateTime = value;
            }
        }

        [XmlIgnore]
        protected bool StartDateTimeSpecified { get; set; }

        private string _endDateTime;

        [XmlElement(ElementName = "endDateTime", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2178")]
        public string EndDateTime
        {
            get => _endDateTime;
            set
            {
                EndDateTimeSpecified = true;
                _endDateTime = value;
            }
        }

        [XmlIgnore]
        protected bool EndDateTimeSpecified { get; set; }

    }
}
