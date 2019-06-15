using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a system voice portal instance.
    /// The response is either SystemSystemVoicePortalGetResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemSystemVoicePortalGetRequest21sp1.
        /// <see cref="SystemSystemVoicePortalGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemSystemVoicePortalGetRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSystemVoicePortalGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _systemVoicePortalId;

        [XmlElement(ElementName = "systemVoicePortalId", IsNullable = false, Namespace = "")]
        public string SystemVoicePortalId {
            get => _systemVoicePortalId;
            set {
                SystemVoicePortalIdSpecified = true;
                _systemVoicePortalId = value;
            }
        }

        [XmlIgnore]
        public bool SystemVoicePortalIdSpecified { get; set; }
        
    }
}
