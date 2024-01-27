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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:1033""}]")]
    public class SearchCriteriaExactDomainLevel : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.DomainLevel _domainLevel;

        [XmlElement(ElementName = "domainLevel", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:1033")]
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
