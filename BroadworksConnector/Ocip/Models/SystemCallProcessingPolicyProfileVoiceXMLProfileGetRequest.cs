using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the configuration for a call processing policy profile VoiceXML subscriber type profile.
    /// The response is either a SystemCallProcessingPolicyProfileVoiceXMLProfileGetResponse or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemCallProcessingPolicyProfileVoiceXMLProfileGetRequest22
        /// <see cref="SystemCallProcessingPolicyProfileVoiceXMLProfileGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCallProcessingPolicyProfileVoiceXMLProfileGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingPolicyProfileVoiceXMLProfileGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
