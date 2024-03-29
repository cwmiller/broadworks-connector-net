using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of user services that replaces existing user services assigned to the user.
    /// If a service is not authorized to the group, the service will be authorized. The authorizedQuantity will be used if provided; otherwise, the service quantity will be set to unlimited. The command will fail if the authorized Quantity set at the service provider is insufficient.
    /// If a service is already authorized to the group, the service quantity will be ignored if included.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4384""}]")]
    public class ReplacementConsolidatedUserServiceAssignmentList
    {

        protected List<BroadWorksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> _userServiceServiceName = new List<BroadWorksConnector.Ocip.Models.ConsolidatedUserServiceAssignment>();

        [XmlElement(ElementName = "userServiceServiceName", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4384")]
        public List<BroadWorksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> UserServiceServiceName
        {
            get => _userServiceServiceName;
            set
            {
                UserServiceServiceNameSpecified = true;
                _userServiceServiceName = value;
            }
        }

        [XmlIgnore]
        protected bool UserServiceServiceNameSpecified { get; set; }

    }
}
