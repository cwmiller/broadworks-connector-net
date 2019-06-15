using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupUserCallWaitingSettingsGetListRequest.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name", "Hiragana
    /// Last Name", and "Hiragana First Name", "Phone Number",
    /// "Extension", "Department", "In Trunk Group", "Email Address", "Is Active".
    /// "Is Active" is "true" or "false".
    /// "Phone Number" is presented in the E164 format.
        /// <see cref="GroupUserCallWaitingSettingsGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupUserCallWaitingSettingsGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _userCallWaitingTable;

        [XmlElement(ElementName = "userCallWaitingTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserCallWaitingTable {
            get => _userCallWaitingTable;
            set {
                UserCallWaitingTableSpecified = true;
                _userCallWaitingTable = value;
            }
        }

        [XmlIgnore]
        public bool UserCallWaitingTableSpecified { get; set; }
        
    }
}
