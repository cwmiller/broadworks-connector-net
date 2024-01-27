using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of user services that replaces a previously authorized user services.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4297""}]")]
    public class ReplacementCombinedUserServiceAuthorizationList
    {

        protected List<BroadWorksConnector.Ocip.Models.CombinedUserServiceAuthorization> _userServiceAuthorization = new List<BroadWorksConnector.Ocip.Models.CombinedUserServiceAuthorization>();

        [XmlElement(ElementName = "userServiceAuthorization", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4297")]
        public List<BroadWorksConnector.Ocip.Models.CombinedUserServiceAuthorization> UserServiceAuthorization
        {
            get => _userServiceAuthorization;
            set
            {
                UserServiceAuthorizationSpecified = true;
                _userServiceAuthorization = value;
            }
        }

        [XmlIgnore]
        protected bool UserServiceAuthorizationSpecified { get; set; }

    }
}
