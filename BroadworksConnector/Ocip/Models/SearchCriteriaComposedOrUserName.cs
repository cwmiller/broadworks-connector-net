using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a user's full name.
    /// This search criterion will be compared against multiple combinations of first name and last name:
    /// 
    /// First Name + ‘ ‘ + Last Name
    /// Last Name + ‘ ‘ + First Name
    /// Hiragana Last Name + ' ' + Hiragana First Name
    /// 
    /// Note: For this search criterion, the searchMode is always ‘Contains’ and the search criteria are always OR’ed.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:400""}]")]
    public class SearchCriteriaComposedOrUserName : BroadWorksConnector.Ocip.Models.SearchCriteriaComposedOr
    {

        protected List<string> _value = new List<string>();

        [XmlElement(ElementName = "value", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:400")]
        [MinLength(1)]
        [MaxLength(255)]
        public List<string> Value
        {
            get => _value;
            set
            {
                ValueSpecified = true;
                _value = value;
            }
        }

        [XmlIgnore]
        protected bool ValueSpecified { get; set; }

        protected bool _isCaseInsensitive;

        [XmlElement(ElementName = "isCaseInsensitive", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:400")]
        public bool IsCaseInsensitive
        {
            get => _isCaseInsensitive;
            set
            {
                IsCaseInsensitiveSpecified = true;
                _isCaseInsensitive = value;
            }
        }

        [XmlIgnore]
        protected bool IsCaseInsensitiveSpecified { get; set; }

    }
}
