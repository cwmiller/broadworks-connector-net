using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular user's personId.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:1382""}]")]
    public class SearchCriteriaExactUserPersonId : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected string _userPersonId;

        [XmlElement(ElementName = "userPersonId", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:1382")]
        [MaxLength(82)]
        public string UserPersonId
        {
            get => _userPersonId;
            set
            {
                UserPersonIdSpecified = true;
                _userPersonId = value;
            }
        }

        [XmlIgnore]
        protected bool UserPersonIdSpecified { get; set; }

    }
}
