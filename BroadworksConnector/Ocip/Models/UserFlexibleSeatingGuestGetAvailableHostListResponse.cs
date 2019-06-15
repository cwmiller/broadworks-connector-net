using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserFlexibleSeatingGuestGetAvailableHostListRequest.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address", "Association Limit Hours", "Enable Association Limit",
        /// <see cref="UserFlexibleSeatingGuestGetAvailableHostListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserFlexibleSeatingGuestGetAvailableHostListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _hostUserTable;

        [XmlElement(ElementName = "hostUserTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable HostUserTable {
            get => _hostUserTable;
            set {
                HostUserTableSpecified = true;
                _hostUserTable = value;
            }
        }

        [XmlIgnore]
        public bool HostUserTableSpecified { get; set; }
        
    }
}
