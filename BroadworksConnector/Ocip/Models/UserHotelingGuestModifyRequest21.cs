using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Hoteling Guest.
    /// Provisioning error will be given when setting hostUserId to not nil value while Hoteling Guest feature is not active.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserHotelingGuestModifyRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive {
            get => _isActive;
            set {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
        
        private bool _enableAssociationLimit;

        [XmlElement(ElementName = "enableAssociationLimit", IsNullable = false, Namespace = "")]
        public bool EnableAssociationLimit {
            get => _enableAssociationLimit;
            set {
                EnableAssociationLimitSpecified = true;
                _enableAssociationLimit = value;
            }
        }

        [XmlIgnore]
        public bool EnableAssociationLimitSpecified { get; set; }
        
        private int _associationLimitHours;

        [XmlElement(ElementName = "associationLimitHours", IsNullable = false, Namespace = "")]
        public int AssociationLimitHours {
            get => _associationLimitHours;
            set {
                AssociationLimitHoursSpecified = true;
                _associationLimitHours = value;
            }
        }

        [XmlIgnore]
        public bool AssociationLimitHoursSpecified { get; set; }
        
        private string _hostUserId;

        [XmlElement(ElementName = "hostUserId", IsNullable = true, Namespace = "")]
        public string HostUserId {
            get => _hostUserId;
            set {
                HostUserIdSpecified = true;
                _hostUserId = value;
            }
        }

        [XmlIgnore]
        public bool HostUserIdSpecified { get; set; }
        
    }
}
