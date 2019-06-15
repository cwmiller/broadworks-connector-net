using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupThirdPartyVoiceMailSupportGetRequest.
        /// <see cref="GroupThirdPartyVoiceMailSupportGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupThirdPartyVoiceMailSupportGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive {
            get => _isActive;
            set {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
        
        private string _groupServer;

        [XmlElement(ElementName = "groupServer", IsNullable = false, Namespace = "")]
        public string GroupServer {
            get => _groupServer;
            set {
                GroupServerSpecified = true;
                _groupServer = value;
            }
        }

        [XmlIgnore]
        public bool GroupServerSpecified { get; set; }
        
    }
}
