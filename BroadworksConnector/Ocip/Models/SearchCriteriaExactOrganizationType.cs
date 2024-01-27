using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for an organization type.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:1153""}]")]
    public class SearchCriteriaExactOrganizationType : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.OrganizationType _organizationType;

        [XmlElement(ElementName = "organizationType", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:1153")]
        public BroadWorksConnector.Ocip.Models.OrganizationType OrganizationType
        {
            get => _organizationType;
            set
            {
                OrganizationTypeSpecified = true;
                _organizationType = value;
            }
        }

        [XmlIgnore]
        protected bool OrganizationTypeSpecified { get; set; }

    }
}
