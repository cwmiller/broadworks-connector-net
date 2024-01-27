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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4104""}]")]
    public class RecurrenceRecurDaily
    {

        protected int _recurInterval;

        [XmlElement(ElementName = "recurInterval", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4104")]
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

    }
}
