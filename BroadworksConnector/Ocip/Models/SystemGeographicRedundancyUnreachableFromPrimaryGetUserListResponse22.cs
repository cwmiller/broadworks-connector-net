using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22.
    /// The Unreachable From Primary User table column headings are: "User ID", "Lineport".
    /// The optional totalNumberOfUnreachableFromPrimaryUsers is returned only when the userListSizeLimit is set in the request and
    /// if the total number of unreachable from primary users is greater than the value of userListSizeLimit.
        /// <see cref="SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _unreachableFromPrimaryUserTable;

        [XmlElement(ElementName = "unreachableFromPrimaryUserTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UnreachableFromPrimaryUserTable {
            get => _unreachableFromPrimaryUserTable;
            set {
                UnreachableFromPrimaryUserTableSpecified = true;
                _unreachableFromPrimaryUserTable = value;
            }
        }

        [XmlIgnore]
        public bool UnreachableFromPrimaryUserTableSpecified { get; set; }
        
        private int _totalNumberOfUnreachableFromPrimaryUsers;

        [XmlElement(ElementName = "totalNumberOfUnreachableFromPrimaryUsers", IsNullable = false, Namespace = "")]
        public int TotalNumberOfUnreachableFromPrimaryUsers {
            get => _totalNumberOfUnreachableFromPrimaryUsers;
            set {
                TotalNumberOfUnreachableFromPrimaryUsersSpecified = true;
                _totalNumberOfUnreachableFromPrimaryUsers = value;
            }
        }

        [XmlIgnore]
        public bool TotalNumberOfUnreachableFromPrimaryUsersSpecified { get; set; }
        
    }
}
