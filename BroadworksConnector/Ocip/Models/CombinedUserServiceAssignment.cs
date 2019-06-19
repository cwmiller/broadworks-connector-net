using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Assign a service user. If the service has not been authorized to service provider or group, it will
    /// be authorized.
    /// 
    /// If the service needs to be authorized at group/service provider levels, the authorizedQuantity
    /// will be used. Otherwise, it will be ignored. If the authorizedQuantity is not included, the
    /// quantity will come from the group template for the service. If a template does
    /// not exist, the service quantity will be set to unlimited.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:1302""}]")]
    public class CombinedUserServiceAssignment
    {

        private BroadWorksConnector.Ocip.Models.UserService _userService;

        [XmlElement(ElementName = "userService", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1302")]
        public BroadWorksConnector.Ocip.Models.UserService UserService
        {
            get => _userService;
            set
            {
                UserServiceSpecified = true;
                _userService = value;
            }
        }

        [XmlIgnore]
        public bool UserServiceSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _authorizedQuantity;

        [XmlElement(ElementName = "authorizedQuantity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1302")]
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
        public bool AuthorizedQuantitySpecified { get; set; }

    }
}
