using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the configuration for a call processing policy profile Flexible Seating Host subscriber
    /// type profile.
    /// The response is either a SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetRequest22
        /// <see cref="SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _callProcessingPolicyProfileName;

        [XmlElement(ElementName = "callProcessingPolicyProfileName", IsNullable = false, Namespace = "")]
        public string CallProcessingPolicyProfileName {
            get => _callProcessingPolicyProfileName;
            set {
                CallProcessingPolicyProfileNameSpecified = true;
                _callProcessingPolicyProfileName = value;
            }
        }

        [XmlIgnore]
        public bool CallProcessingPolicyProfileNameSpecified { get; set; }
        
    }
}
