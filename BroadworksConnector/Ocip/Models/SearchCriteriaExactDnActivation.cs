using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular Dn activation state.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:988""}]")]
    public class SearchCriteriaExactDnActivation : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected bool _activated;

        [XmlElement(ElementName = "activated", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:988")]
        public bool Activated
        {
            get => _activated;
            set
            {
                ActivatedSpecified = true;
                _activated = value;
            }
        }

        [XmlIgnore]
        protected bool ActivatedSpecified { get; set; }

    }
}
