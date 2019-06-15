using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of available access devices for assignment to a user
    /// within a group. The list includes devices created at the system, service provider, and group levels.
    /// The response is either GroupAccessDeviceGetAvailableDetailListResponse14 or
    /// ErrorResponse.
    /// 
    /// Replaced by: GroupAccessDeviceGetAvailableDetailListRequest19.
        /// <see cref="GroupAccessDeviceGetAvailableDetailListResponse14"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupAccessDeviceGetAvailableDetailListRequest19"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupAccessDeviceGetAvailableDetailListRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private bool _isMusicOnHold;

        [XmlElement(ElementName = "isMusicOnHold", IsNullable = false, Namespace = "")]
        public bool IsMusicOnHold {
            get => _isMusicOnHold;
            set {
                IsMusicOnHoldSpecified = true;
                _isMusicOnHold = value;
            }
        }

        [XmlIgnore]
        public bool IsMusicOnHoldSpecified { get; set; }
        
        private bool _onlyVideoCapable;

        [XmlElement(ElementName = "onlyVideoCapable", IsNullable = false, Namespace = "")]
        public bool OnlyVideoCapable {
            get => _onlyVideoCapable;
            set {
                OnlyVideoCapableSpecified = true;
                _onlyVideoCapable = value;
            }
        }

        [XmlIgnore]
        public bool OnlyVideoCapableSpecified { get; set; }
        
    }
}
