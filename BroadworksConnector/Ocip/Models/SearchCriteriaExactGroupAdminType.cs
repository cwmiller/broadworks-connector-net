using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular group administrator type.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:1063""}]")]
    public class SearchCriteriaExactGroupAdminType : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.GroupAdminType _type;

        [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:1063")]
        public BroadWorksConnector.Ocip.Models.GroupAdminType Type
        {
            get => _type;
            set
            {
                TypeSpecified = true;
                _type = value;
            }
        }

        [XmlIgnore]
        protected bool TypeSpecified { get; set; }

    }
}
