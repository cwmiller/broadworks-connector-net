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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:400""}]")]
    public class SearchCriteriaComposedOrUserName : BroadWorksConnector.Ocip.Models.SearchCriteriaComposedOr
    {

        private List<string> _value = new List<string>();

        [XmlElement(ElementName = "value", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:400")]
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

        private bool _isCaseInsensitive;

        [XmlElement(ElementName = "isCaseInsensitive", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:400")]
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
