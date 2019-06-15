using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the user information. The response is either UserGetResponse21sp1V2 or ErrorResponse.
    /// 
    /// Replaced by UserGetRequest22V3 in AS data mode
        /// <see cref="UserGetResponse21sp1V2"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserGetRequest22V3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserGetRequest21sp1V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
