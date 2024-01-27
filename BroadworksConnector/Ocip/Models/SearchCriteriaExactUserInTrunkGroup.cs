using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for user in/not in a trunk group.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:1349""}]")]
    public class SearchCriteriaExactUserInTrunkGroup : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected bool _userInTrunkGroup;

        [XmlElement(ElementName = "userInTrunkGroup", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:1349")]
        public bool UserInTrunkGroup
        {
            get => _userInTrunkGroup;
            set
            {
                UserInTrunkGroupSpecified = true;
                _userInTrunkGroup = value;
            }
        }

        [XmlIgnore]
        protected bool UserInTrunkGroupSpecified { get; set; }

    }
}
