using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Returns the Sh non-transparent data stored against a userId.
    /// The response is either a UserShInterfaceGetUserIdDataResponse or an ErrorResponse.
    /// 
    /// Replaced by: UserShInterfaceGetUserIdDataRequest21sp1 in AS data mode.
        /// <see cref="UserShInterfaceGetUserIdDataResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserShInterfaceGetUserIdDataRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserShInterfaceGetUserIdDataRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
