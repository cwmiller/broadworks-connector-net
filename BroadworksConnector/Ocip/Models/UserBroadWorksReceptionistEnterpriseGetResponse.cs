using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserBroadWorksReceptionistEnterpriseGetRequest.
    /// Returns a 12 column table with column headings:
    /// "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Group Id", "Phone Number", "Extension", "Mobile", "Email Address", "Department", "IMP Id", "Title",
    /// "Receptionist Note".
    /// The Receptionist Note column is only populated, if the user sending the request is the owner
    /// of the Receptionist Note and a Note exists.
        /// <see cref="UserBroadWorksReceptionistEnterpriseGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserBroadWorksReceptionistEnterpriseGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _monitoredUserTable;

        [XmlElement(ElementName = "monitoredUserTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MonitoredUserTable {
            get => _monitoredUserTable;
            set {
                MonitoredUserTableSpecified = true;
                _monitoredUserTable = value;
            }
        }

        [XmlIgnore]
        public bool MonitoredUserTableSpecified { get; set; }
        
    }
}
