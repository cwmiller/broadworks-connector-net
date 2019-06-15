using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the Call Center Enhanced configuration data for a
    /// Call Center.
    /// The response is either GroupCallCenterEnhancedGetResponse or
    /// ErrorResponse.
    /// 
    /// Replaced By: GroupCallCenterGetInstanceResponse16
        /// <see cref="GroupCallCenterEnhancedGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupCallCenterGetInstanceResponse16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterEnhancedGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
