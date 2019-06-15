using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a user's full name.
    /// This search criterion will be compared against multiple combinations of first name and last name:
    /// 
    /// First Name + ‘ ‘ + Last Name
    /// Last Name + ‘ ‘ + First Name
    /// Last Name + ‘, ‘ + First Name
    /// Hiragana Last Name + Hiragana First Name
    /// 
    /// Note that when specific conditions are met, VON users will be included in the search results.
    /// Note: For this search criterion, the searchMode is always ‘Contains’ and the multi-part search criteria are always AND’ed.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaMultiPartUserName : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private List<string> _value;

        [XmlElement(ElementName = "value", IsNullable = false, Namespace = "")]
        public List<string> Value {
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
