using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the group level data associated with Emergency Zones.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupEmergencyZonesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private BroadWorksConnector.Ocip.Models.EmergencyZonesProhibition _emergencyZonesProhibition;

        [XmlElement(ElementName = "emergencyZonesProhibition", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EmergencyZonesProhibition EmergencyZonesProhibition {
            get => _emergencyZonesProhibition;
            set {
                EmergencyZonesProhibitionSpecified = true;
                _emergencyZonesProhibition = value;
            }
        }

        [XmlIgnore]
        public bool EmergencyZonesProhibitionSpecified { get; set; }
        
        private bool _sendEmergencyCallNotifyEmail;

        [XmlElement(ElementName = "sendEmergencyCallNotifyEmail", IsNullable = false, Namespace = "")]
        public bool SendEmergencyCallNotifyEmail {
            get => _sendEmergencyCallNotifyEmail;
            set {
                SendEmergencyCallNotifyEmailSpecified = true;
                _sendEmergencyCallNotifyEmail = value;
            }
        }

        [XmlIgnore]
        public bool SendEmergencyCallNotifyEmailSpecified { get; set; }
        
        private string _emergencyCallNotifyEmailAddress;

        [XmlElement(ElementName = "emergencyCallNotifyEmailAddress", IsNullable = true, Namespace = "")]
        public string EmergencyCallNotifyEmailAddress {
            get => _emergencyCallNotifyEmailAddress;
            set {
                EmergencyCallNotifyEmailAddressSpecified = true;
                _emergencyCallNotifyEmailAddress = value;
            }
        }

        [XmlIgnore]
        public bool EmergencyCallNotifyEmailAddressSpecified { get; set; }
        
    }
}
