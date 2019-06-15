using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's Shared Call Appearance service setting.
    /// The response is either a UserSharedCallAppearanceGetResponse14 or an ErrorResponse.
    /// Replaced By: UserSharedCallAppearanceGetRequest14sp2
        /// <see cref="UserSharedCallAppearanceGetResponse14"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserSharedCallAppearanceGetRequest14sp2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserSharedCallAppearanceGetRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
