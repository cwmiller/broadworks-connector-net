using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of feature access codes for a user.
    /// The response is either a UserFeatureAccessCodeGetListResponse or an ErrorResponse.
    /// 
    /// Replaced by: UserFeatureAccessCodeGetListRequest20 in AS data mode
        /// <see cref="UserFeatureAccessCodeGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserFeatureAccessCodeGetListRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserFeatureAccessCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
