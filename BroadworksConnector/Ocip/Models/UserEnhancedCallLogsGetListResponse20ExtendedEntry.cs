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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35800""}]")]
    public class UserEnhancedCallLogsGetListResponse20ExtendedEntry
    {

        private List<BroadWorksConnector.Ocip.Models.ExtendedMixedCallLogsEntry20> _extendedCallLog = new List<BroadWorksConnector.Ocip.Models.ExtendedMixedCallLogsEntry20>();

        [XmlElement(ElementName = "extendedCallLog", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35800")]
        public List<BroadWorksConnector.Ocip.Models.ExtendedMixedCallLogsEntry20> ExtendedCallLog
        {
            get => _extendedCallLog;
            set
            {
                ExtendedCallLogSpecified = true;
                _extendedCallLog = value;
            }
        }

        [XmlIgnore]
        public bool ExtendedCallLogSpecified { get; set; }

    }
}
