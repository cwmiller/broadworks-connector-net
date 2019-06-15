using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of feature access codes for a user.
    /// The response is either a UserFeatureAccessCodeGetListResponse20 or an ErrorResponse.
    /// In release 20 the "Call Recording" FAC name is changed to
    /// "Call Recording Start".
    /// Replaced by: UserFeatureAccessCodeGetListRequest21 in AS data mode
        /// <see cref="UserFeatureAccessCodeGetListResponse20"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserFeatureAccessCodeGetListRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserFeatureAccessCodeGetListRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
