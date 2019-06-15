using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupCommunicationBarringAuthorizationCodeGetListRequest.
    /// Contains a list of Communication Barring Authorization Codes
    /// assigned to the group.
    /// 
    /// Replaced by: GroupCommunicationBarringAuthorizationCodeGetListResponse21sp1 in AS data mode
        /// <see cref="GroupCommunicationBarringAuthorizationCodeGetListRequest"/>
        /// <see cref="GroupCommunicationBarringAuthorizationCodeGetListResponse21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCommunicationBarringAuthorizationCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeEntry> _code;

        [XmlElement(ElementName = "code", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeEntry> Code {
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
