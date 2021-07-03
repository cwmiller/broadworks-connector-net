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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:25576""}]")]
    public class SystemCPEConfigParametersModifyRequestFileRebuildHourly
    {

        private int _startMinute;

        [XmlElement(ElementName = "startMinute", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25576")]
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
        protected bool StartMinuteSpecified { get; set; }

    }
}
