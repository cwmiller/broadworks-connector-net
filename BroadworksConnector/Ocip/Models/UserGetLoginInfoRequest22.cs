using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// UserGetLoginInfoRequest22 is used to access login information for a user
    /// either by a userId, dn or lineport.
    /// The phone number may be any DN associated with a user.
    /// The lineport may be any lineport associated with a user.
    /// 
    /// The response is a UserGetLoginInfoResponse22 or an ErrorResponse
    /// Replaced by UserGetLoginInfoRequest22V2.
        /// <see cref="UserGetLoginInfoRequest22"/>
        /// <see cref="UserGetLoginInfoResponse22"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserGetLoginInfoRequest22V2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserGetLoginInfoRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        public string PhoneNumber {
            get => _phoneNumber;
            set {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }
        
        private string _linePort;

        [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
        public string LinePort {
            get => _linePort;
            set {
                LinePortSpecified = true;
                _linePort = value;
            }
        }

        [XmlIgnore]
        public bool LinePortSpecified { get; set; }
        
    }
}
