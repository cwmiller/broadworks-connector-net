using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular User Type.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:1409""}]")]
    public class SearchCriteriaExactUserType : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.UserType _userType;

        [XmlElement(ElementName = "userType", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:1409")]
        public BroadWorksConnector.Ocip.Models.UserType UserType
        {
            get => _userType;
            set
            {
                UserTypeSpecified = true;
                _userType = value;
            }
        }

        [XmlIgnore]
        protected bool UserTypeSpecified { get; set; }

    }
}
