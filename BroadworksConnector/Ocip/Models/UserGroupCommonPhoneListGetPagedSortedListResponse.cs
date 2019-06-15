using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserGroupCommonPhoneListGetPagedSortedListRequest.
    /// The response contains the group's common phone list. The response
    /// contains a table with column headings: "Name" and "Phone Number".
        /// <see cref="UserGroupCommonPhoneListGetPagedSortedListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserGroupCommonPhoneListGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _groupCommonPhoneListTable;

        [XmlElement(ElementName = "groupCommonPhoneListTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupCommonPhoneListTable {
            get => _groupCommonPhoneListTable;
            set {
                GroupCommonPhoneListTableSpecified = true;
                _groupCommonPhoneListTable = value;
            }
        }

        [XmlIgnore]
        public bool GroupCommonPhoneListTableSpecified { get; set; }
        
    }
}
