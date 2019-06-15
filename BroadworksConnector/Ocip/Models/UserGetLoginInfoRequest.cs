using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// UserGetLoginInfoRequest is used to access login information for a user
    /// either by a userId or dn.
    /// The phone number may be any DN associated with a user.
    /// 
    /// The response is a UserGetLoginInfoResponse or an ErrorResponse
    /// 
    /// Replaced by UserGetLoginInfoRequest22.
        /// <see cref="UserGetLoginInfoRequest"/>
        /// <see cref="UserGetLoginInfoResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserGetLoginInfoRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserGetLoginInfoRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
    }
}
