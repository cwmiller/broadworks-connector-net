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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:1119""}]")]
    public class SearchCriteriaExactOrganizationType : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private BroadWorksConnector.Ocip.Models.OrganizationType _organizationType;

        [XmlElement(ElementName = "organizationType", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:1119")]
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
