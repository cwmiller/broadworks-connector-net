using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupCommunicationBarringAuthorizationCodeGetListRequest21sp1.
    /// Contains a list of Communication Barring Authorization Codes assigned to the group.
        /// <see cref="GroupCommunicationBarringAuthorizationCodeGetListRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCommunicationBarringAuthorizationCodeGetListResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeConfiguration> _code;

        [XmlElement(ElementName = "code", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeConfiguration> Code {
            get => _code;
            set {
                CodeSpecified = true;
                _code = value;
            }
        }

        [XmlIgnore]
        public bool CodeSpecified { get; set; }
        
    }
}
