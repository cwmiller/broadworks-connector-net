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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:3038""}]")]
    public class EnhancedCallLogsTimeRange
    {

        protected string _startDateTime;

        [XmlElement(ElementName = "startDateTime", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3038")]
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

        protected string _endDateTime;

        [XmlElement(ElementName = "endDateTime", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3038")]
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
