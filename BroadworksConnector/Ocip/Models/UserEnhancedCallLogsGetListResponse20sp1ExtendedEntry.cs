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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:42791""}]")]
    public class UserEnhancedCallLogsGetListResponse20sp1ExtendedEntry
    {

        private List<BroadWorksConnector.Ocip.Models.ExtendedMixedCallLogsEntry20sp1> _extendedCallLog = new List<BroadWorksConnector.Ocip.Models.ExtendedMixedCallLogsEntry20sp1>();

        [XmlElement(ElementName = "extendedCallLog", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42791")]
        public List<BroadWorksConnector.Ocip.Models.ExtendedMixedCallLogsEntry20sp1> ExtendedCallLog
        {
            get => _extendedCallLog;
            set
            {
                ExtendedCallLogSpecified = true;
                _extendedCallLog = value;
            }
        }

        [XmlIgnore]
        protected bool ExtendedCallLogSpecified { get; set; }

    }
}
