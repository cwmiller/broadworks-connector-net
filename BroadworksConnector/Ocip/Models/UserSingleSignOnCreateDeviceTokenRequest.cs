using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This command allows a BroadWorks or Third-Party Client Application to
    /// create a Single Sign-On token for a device of a user.
    /// The token is created only if:
    /// 1. the specified user is the owner of a lineport on the specified device
    /// (including a trunk user on a trunk device).
    /// 2. and, the specified device is not in locked state.
    /// 3. and, the device type of the device does support Device Management.
    /// The response is either UserSingleSignOnCreateDeviceTokenResponse
    /// or ErrorResponse.
        /// <see cref="UserSingleSignOnCreateDeviceTokenResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserSingleSignOnCreateDeviceTokenRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private BroadWorksConnector.Ocip.Models.AccessDeviceLevel _deviceLevel;

        [XmlElement(ElementName = "deviceLevel", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceLevel DeviceLevel {
            get => _deviceLevel;
            set {
                DeviceLevelSpecified = true;
                _deviceLevel = value;
            }
        }

        [XmlIgnore]
        public bool DeviceLevelSpecified { get; set; }
        
        private string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        public string DeviceName {
            get => _deviceName;
            set {
                DeviceNameSpecified = true;
                _deviceName = value;
            }
        }

        [XmlIgnore]
        public bool DeviceNameSpecified { get; set; }
        
    }
}
