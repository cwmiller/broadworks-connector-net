using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a DN OR an extension.
    /// Note: For this search criterion, the searchMode is always ‘Contains’ and the search criteria are always OR’ed.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:378""}]")]
    public class SearchCriteriaComposedOrDnExtension : BroadWorksConnector.Ocip.Models.SearchCriteriaComposedOr
    {

        protected BroadWorksConnector.Ocip.Models.UserDNExtension _value;

        [XmlElement(ElementName = "value", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:378")]
        public BroadWorksConnector.Ocip.Models.UserDNExtension Value
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

    }
}
