using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMigratedUsersGetListRequest22.
    /// The optional totalNumberOfMigratedUsers is returned only when the userListSizeLimit is set in the request and
    /// if the total number of migrated users is greater than the value of userListSizeLimit.
        /// <see cref="SystemMigratedUsersGetListRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMigratedUsersGetListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public List<string> UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private int _totalNumberOfMigratedUsers;

        [XmlElement(ElementName = "totalNumberOfMigratedUsers", IsNullable = false, Namespace = "")]
        public int TotalNumberOfMigratedUsers {
            get => _totalNumberOfMigratedUsers;
            set {
                TotalNumberOfMigratedUsersSpecified = true;
                _totalNumberOfMigratedUsers = value;
            }
        }

        [XmlIgnore]
        public bool TotalNumberOfMigratedUsersSpecified { get; set; }
        
    }
}
