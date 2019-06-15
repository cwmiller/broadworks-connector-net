using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Move the user from one group to another group within the same enterprise.
    /// If evaluateOnly is specified, no actual move will happen. The command only tests the move and reports the impacts or possible conditions preventing the move.
    /// The response is either UserModifyGroupIdResponse or ErrorResponse.
        /// <see cref="UserModifyGroupIdResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserModifyGroupIdRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private string _newGroupId;

        [XmlElement(ElementName = "newGroupId", IsNullable = false, Namespace = "")]
        public string NewGroupId {
            get => _newGroupId;
            set {
                NewGroupIdSpecified = true;
                _newGroupId = value;
            }
        }

        [XmlIgnore]
        public bool NewGroupIdSpecified { get; set; }
        
        private bool _evaluateOnly;

        [XmlElement(ElementName = "evaluateOnly", IsNullable = false, Namespace = "")]
        public bool EvaluateOnly {
            get => _evaluateOnly;
            set {
                EvaluateOnlySpecified = true;
                _evaluateOnly = value;
            }
        }

        [XmlIgnore]
        public bool EvaluateOnlySpecified { get; set; }
        
    }
}
