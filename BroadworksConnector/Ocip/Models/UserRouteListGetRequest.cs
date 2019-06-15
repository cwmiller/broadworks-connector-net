using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the route list setting and the list of number ranges assigned to a user.
    /// The response is either UserRouteListGetResponse or ErrorResponse.
    /// 
    /// Replaced by: UserRouteListGetRequest22
        /// <see cref="UserRouteListGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserRouteListGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserRouteListGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
