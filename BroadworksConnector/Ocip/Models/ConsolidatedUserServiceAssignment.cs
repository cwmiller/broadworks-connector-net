using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Assign a user service. If the service has not been authorized to the group, it will be authorized.
    /// The authorizedQuantity will be used at the group level if provided; otherwise, the service quantity will be set to unlimited.
    /// The command will fail if the authorized quantity set at the service provider level is insufficient.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:1857""}]")]
    public class ConsolidatedUserServiceAssignment
    {

        protected BroadWorksConnector.Ocip.Models.UserService _userServiceName;

        [XmlElement(ElementName = "userServiceName", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1857")]
        public BroadWorksConnector.Ocip.Models.UserService UserServiceName
        {
            get => _userServiceName;
            set
            {
                UserServiceNameSpecified = true;
                _userServiceName = value;
            }
        }

        [XmlIgnore]
        protected bool UserServiceNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _authorizedQuantity;

        [XmlElement(ElementName = "authorizedQuantity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1857")]
        public BroadWorksConnector.Ocip.Models.UnboundedPositiveInt AuthorizedQuantity
        {
            get => _authorizedQuantity;
            set
            {
                AuthorizedQuantitySpecified = true;
                _authorizedQuantity = value;
            }
        }

        [XmlIgnore]
        protected bool AuthorizedQuantitySpecified { get; set; }

    }
}
