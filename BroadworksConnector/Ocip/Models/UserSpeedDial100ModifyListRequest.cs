using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the speed dial 100 settings for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Engineering Note: This command is used internally by Call Processing.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserSpeedDial100ModifyListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private List<BroadWorksConnector.Ocip.Models.SpeedDial100EntryModify> _speedDialEntry;

        [XmlElement(ElementName = "speedDialEntry", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SpeedDial100EntryModify> SpeedDialEntry {
            get => _speedDialEntry;
            set {
                SpeedDialEntrySpecified = true;
                _speedDialEntry = value;
            }
        }

        [XmlIgnore]
        public bool SpeedDialEntrySpecified { get; set; }
        
    }
}
