using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular fully specified hunt policy.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:1078""}]")]
    public class SearchCriteriaExactHuntPolicy : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.HuntPolicy _huntPolicy;

        [XmlElement(ElementName = "huntPolicy", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:1078")]
        public BroadWorksConnector.Ocip.Models.HuntPolicy HuntPolicy
        {
            get => _huntPolicy;
            set
            {
                HuntPolicySpecified = true;
                _huntPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool HuntPolicySpecified { get; set; }

    }
}
