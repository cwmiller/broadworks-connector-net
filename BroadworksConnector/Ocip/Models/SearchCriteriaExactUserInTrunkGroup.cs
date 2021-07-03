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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:1300""}]")]
    public class SearchCriteriaExactUserInTrunkGroup : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private bool _userInTrunkGroup;

        [XmlElement(ElementName = "userInTrunkGroup", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:1300")]
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
