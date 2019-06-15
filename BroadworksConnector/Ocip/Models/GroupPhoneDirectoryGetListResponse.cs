using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupPhoneDirectoryGetListRequest.
    /// Contains a table with a row for each phone number and column headings :
    /// "Name", "Number", "Extension", "Mobile", "Email Address", "Department", "Hiragana Name", "Group Id",
    /// "Yahoo Id".
    /// If extended directory information is requested, the following columns are also included:
    /// "First Name", "Last Name", "User Id", "Pager", "Title", "Time Zone", "Location", "Address Line 1",
    /// "Address Line 2",
    /// "City", "State", "Zip", "Country".
    /// 
    /// Replace by: GroupPhoneDirectoryGetListResponse17
        /// <see cref="GroupPhoneDirectoryGetListRequest"/>
        /// <see cref="GroupPhoneDirectoryGetListResponse17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupPhoneDirectoryGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _directoryTable;

        [XmlElement(ElementName = "directoryTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DirectoryTable {
            get => _directoryTable;
            set {
                DirectoryTableSpecified = true;
                _directoryTable = value;
            }
        }

        [XmlIgnore]
        public bool DirectoryTableSpecified { get; set; }
        
    }
}
