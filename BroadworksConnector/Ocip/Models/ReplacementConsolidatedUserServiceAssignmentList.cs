using System;
using System.Xml.Serialization;
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
     
    public class ReplacementConsolidatedUserServiceAssignmentList 
    {

        
        private List<BroadWorksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> _userServiceServiceName;

        [XmlElement(ElementName = "userServiceServiceName", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> UserServiceServiceName {
            get => _userServiceServiceName;
            set {
                UserServiceServiceNameSpecified = true;
                _userServiceServiceName = value;
            }
        }

        [XmlIgnore]
        public bool UserServiceServiceNameSpecified { get; set; }
        
    }
}
