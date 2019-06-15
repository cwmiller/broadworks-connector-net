using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of users assigned the user service or service pack.
    /// The response is either a GroupGetUserServiceAssignedUserListResponse or an ErrorResponse.
        /// <see cref="GroupGetUserServiceAssignedUserListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupGetUserServiceAssignedUserListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.UserService _serviceName;

        [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UserService ServiceName {
            get => _serviceName;
            set {
                ServiceNameSpecified = true;
                _serviceName = value;
            }
        }

        [XmlIgnore]
        public bool ServiceNameSpecified { get; set; }
        
        private string _servicePackName;

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        public string ServicePackName {
            get => _servicePackName;
            set {
                ServicePackNameSpecified = true;
                _servicePackName = value;
            }
        }

        [XmlIgnore]
        public bool ServicePackNameSpecified { get; set; }
        
    }
}
