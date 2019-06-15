using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserModifyGroupIdRequest.
    /// error indicates the failing conditions preventing the user move.
    /// impact indicates any change to user and group as the result of a user move.
        /// <see cref="UserModifyGroupIdRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserModifyGroupIdResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.UserMoveMessage> _error;

        [XmlElement(ElementName = "error", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.UserMoveMessage> Error {
            get => _error;
            set {
                ErrorSpecified = true;
                _error = value;
            }
        }

        [XmlIgnore]
        public bool ErrorSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.UserMoveMessage> _impact;

        [XmlElement(ElementName = "impact", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.UserMoveMessage> Impact {
            get => _impact;
            set {
                ImpactSpecified = true;
                _impact = value;
            }
        }

        [XmlIgnore]
        public bool ImpactSpecified { get; set; }
        
    }
}
