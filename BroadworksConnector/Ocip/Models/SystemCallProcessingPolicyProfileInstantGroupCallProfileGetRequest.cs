using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the configuration for a call processing policy profile Instant Group Call subscriber type
    /// profile.
    /// The response is either a SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22 or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemCallProcessingPolicyProfileInstantGroupCallProfileGetRequest22
        /// <see cref="SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallProcessingPolicyProfileInstantGroupCallProfileGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingPolicyProfileInstantGroupCallProfileGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
