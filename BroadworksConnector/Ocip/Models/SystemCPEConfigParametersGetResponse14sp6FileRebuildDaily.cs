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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:34534""}]")]
    public class SystemCPEConfigParametersGetResponse14sp6FileRebuildDaily
    {

        private int _startHour;

        [XmlElement(ElementName = "startHour", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34534")]
        [MinInclusive(0)]
        [MaxInclusive(23)]
        public int StartHour
        {
            get => _startHour;
            set
            {
                StartHourSpecified = true;
                _startHour = value;
            }
        }

        [XmlIgnore]
        public bool StartHourSpecified { get; set; }

        private int _startMinute;

        [XmlElement(ElementName = "startMinute", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34534")]
        [MinInclusive(0)]
        [MaxInclusive(59)]
        public int StartMinute
        {
            get => _startMinute;
            set
            {
                StartMinuteSpecified = true;
                _startMinute = value;
            }
        }

        [XmlIgnore]
        public bool StartMinuteSpecified { get; set; }

    }
}
