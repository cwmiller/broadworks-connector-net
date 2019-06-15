using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserPersonalPhoneListGetPagedSortedListRequest.
    /// The response contains a user's personal phone list. The response
    /// contains a table with column headings: "Name" and "Phone Number".
        /// <see cref="UserPersonalPhoneListGetPagedSortedListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserPersonalPhoneListGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private int _totalNumberOfRows;

        [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
        public int TotalNumberOfRows {
            get => _totalNumberOfRows;
            set {
                TotalNumberOfRowsSpecified = true;
                _totalNumberOfRows = value;
            }
        }

        [XmlIgnore]
        public bool TotalNumberOfRowsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _personalPhoneListTable;

        [XmlElement(ElementName = "personalPhoneListTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable PersonalPhoneListTable {
            get => _personalPhoneListTable;
            set {
                PersonalPhoneListTableSpecified = true;
                _personalPhoneListTable = value;
            }
        }

        [XmlIgnore]
        public bool PersonalPhoneListTableSpecified { get; set; }
        
    }
}
