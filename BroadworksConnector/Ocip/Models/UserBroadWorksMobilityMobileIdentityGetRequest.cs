using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the settings for a user's specified mobile identity.
    /// The response is either a UserBroadWorksMobilityMobileIdentityGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: UserBroadWorksMobilityMobileIdentityGetRequest21sp1.
        /// <see cref="UserBroadWorksMobilityMobileIdentityGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserBroadWorksMobilityMobileIdentityGetRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserBroadWorksMobilityMobileIdentityGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private string _mobileNumber;

        [XmlElement(ElementName = "mobileNumber", IsNullable = false, Namespace = "")]
        public string MobileNumber {
            get => _mobileNumber;
            set {
                MobileNumberSpecified = true;
                _mobileNumber = value;
            }
        }

        [XmlIgnore]
        public bool MobileNumberSpecified { get; set; }
        
    }
}
