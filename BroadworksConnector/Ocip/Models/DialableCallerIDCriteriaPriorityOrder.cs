using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Dialable Caller ID routing order
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2088""}]")]
    public class DialableCallerIDCriteriaPriorityOrder
    {

        private string _criteriaName;

        [XmlElement(ElementName = "criteriaName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2088")]
        [MinLength(1)]
        [MaxLength(40)]
        public string CriteriaName
        {
            get => _criteriaName;
            set
            {
                CriteriaNameSpecified = true;
                _criteriaName = value;
            }
        }

        [XmlIgnore]
        public bool CriteriaNameSpecified { get; set; }

        private decimal _priority;

        [XmlElement(ElementName = "priority", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2088")]
        [MinInclusive(0)]
        [MaxInclusive(1000000)]
        public decimal Priority
        {
            get => _priority;
            set
            {
                PrioritySpecified = true;
                _priority = value;
            }
        }

        [XmlIgnore]
        public bool PrioritySpecified { get; set; }

    }
}
