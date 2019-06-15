using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the settings for the busy lamp field service.
    /// The response is either a UserBusyLampFieldGetResponse or an ErrorResponse.
    /// Replaced by: UserBusyLampFieldGetRequest16sp2
        /// <see cref="UserBusyLampFieldGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserBusyLampFieldGetRequest16sp2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserBusyLampFieldGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
