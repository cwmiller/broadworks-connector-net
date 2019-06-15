using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a name in a group common phone list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaGroupCommonPhoneListName : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private BroadWorksConnector.Ocip.Models.SearchMode _mode;

        [XmlElement(ElementName = "mode", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SearchMode Mode {
            get => _mode;
            set {
                ModeSpecified = true;
                _mode = value;
            }
        }

        [XmlIgnore]
        public bool ModeSpecified { get; set; }
        
        private string _value;

        [XmlElement(ElementName = "value", IsNullable = false, Namespace = "")]
        public string Value {
            get => _value;
            set {
                ValueSpecified = true;
                _value = value;
            }
        }

        [XmlIgnore]
        public bool ValueSpecified { get; set; }
        
        private bool _isCaseInsensitive;

        [XmlElement(ElementName = "isCaseInsensitive", IsNullable = false, Namespace = "")]
        public bool IsCaseInsensitive {
            get => _isCaseInsensitive;
            set {
                IsCaseInsensitiveSpecified = true;
                _isCaseInsensitive = value;
            }
        }

        [XmlIgnore]
        public bool IsCaseInsensitiveSpecified { get; set; }
        
    }
}
