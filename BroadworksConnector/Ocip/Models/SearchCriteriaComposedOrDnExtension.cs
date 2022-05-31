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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:378""}]")]
    public class SearchCriteriaComposedOrDnExtension : BroadWorksConnector.Ocip.Models.SearchCriteriaComposedOr
    {

        protected BroadWorksConnector.Ocip.Models.UserDNExtension _value;

        [XmlElement(ElementName = "value", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:378")]
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
