using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the information of a VoiceXML instance.
    /// The response is either GroupVoiceXmlGetInstanceResponse or ErrorResponse.
    /// 
    /// Replaced by: GroupVoiceXmlGetInstanceRequest19sp1 in AS data mode
        /// <see cref="GroupVoiceXmlGetInstanceResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupVoiceXmlGetInstanceRequest19sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupVoiceXmlGetInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
