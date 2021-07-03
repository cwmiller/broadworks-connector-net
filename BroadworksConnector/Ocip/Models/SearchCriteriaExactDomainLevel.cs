using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular domain level.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:999""}]")]
    public class SearchCriteriaExactDomainLevel : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private BroadWorksConnector.Ocip.Models.DomainLevel _domainLevel;

        [XmlElement(ElementName = "domainLevel", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:999")]
        public BroadWorksConnector.Ocip.Models.DomainLevel DomainLevel
        {
            get => _domainLevel;
            set
            {
                DomainLevelSpecified = true;
                _domainLevel = value;
            }
        }

        [XmlIgnore]
        protected bool DomainLevelSpecified { get; set; }

    }
}
