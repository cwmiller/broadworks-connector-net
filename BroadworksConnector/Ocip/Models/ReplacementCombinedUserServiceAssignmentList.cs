using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of user services that replaces existing user services assgined to the user.
    /// 
    /// If a service is already assigned to the user, the service quantitiy will be updated if included.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ReplacementCombinedUserServiceAssignmentList 
    {

        
        private List<BroadWorksConnector.Ocip.Models.CombinedUserServiceAssignment> _serviceName;

        [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CombinedUserServiceAssignment> ServiceName {
            get => _serviceName;
            set {
                ServiceNameSpecified = true;
                _serviceName = value;
            }
        }

        [XmlIgnore]
        public bool ServiceNameSpecified { get; set; }
        
    }
}
