using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserHotelingGuestGetRequest14.
    /// Replaced By: UserSharedCallAppearanceAddEndpointRequest14sp2
        /// <see cref="UserHotelingGuestGetRequest14"/>
        /// <see cref="UserSharedCallAppearanceAddEndpointRequest14sp2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserHotelingGuestGetResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
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

        [XmlElement(ElementName = "hostUserId", IsNullable = false, Namespace = "")]
        public string HostUserId {
            get => _hostUserId;
            set {
                HostUserIdSpecified = true;
                _hostUserId = value;
            }
        }

        [XmlIgnore]
        public bool HostUserIdSpecified { get; set; }
        
        private string _hostLastName;

        [XmlElement(ElementName = "hostLastName", IsNullable = false, Namespace = "")]
        public string HostLastName {
            get => _hostLastName;
            set {
                HostLastNameSpecified = true;
                _hostLastName = value;
            }
        }

        [XmlIgnore]
        public bool HostLastNameSpecified { get; set; }
        
        private string _hostFirstName;

        [XmlElement(ElementName = "hostFirstName", IsNullable = false, Namespace = "")]
        public string HostFirstName {
            get => _hostFirstName;
            set {
                HostFirstNameSpecified = true;
                _hostFirstName = value;
            }
        }

        [XmlIgnore]
        public bool HostFirstNameSpecified { get; set; }
        
        private string _hostAssociationDateTime;

        [XmlElement(ElementName = "hostAssociationDateTime", IsNullable = false, Namespace = "")]
        public string HostAssociationDateTime {
            get => _hostAssociationDateTime;
            set {
                HostAssociationDateTimeSpecified = true;
                _hostAssociationDateTime = value;
            }
        }

        [XmlIgnore]
        public bool HostAssociationDateTimeSpecified { get; set; }
        
    }
}
