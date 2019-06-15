using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's Shared Call Appearance service setting.
    /// The response is either a UserSharedCallAppearanceGetResponse16sp2 or an ErrorResponse.
    /// Replaced by: UserSharedCallAppearanceGetRequest21sp1.
        /// <see cref="UserSharedCallAppearanceGetResponse16sp2"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserSharedCallAppearanceGetRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserSharedCallAppearanceGetRequest16sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
    }
}
