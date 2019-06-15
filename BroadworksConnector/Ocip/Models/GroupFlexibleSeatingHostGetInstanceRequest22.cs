using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the information of a flexible seating host instance.
    /// The response is either GroupFlexibleSeatingHostGetInstanceResponse22 or ErrorResponse.
        /// <see cref="GroupFlexibleSeatingHostGetInstanceResponse22"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupFlexibleSeatingHostGetInstanceRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
    }
}
