using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMigratedUsersGetListRequest.
    /// 
    /// Replaced by: SystemMigratedUsersGetListResponse22 in AS data mode
        /// <see cref="SystemMigratedUsersGetListRequest"/>
        /// <see cref="SystemMigratedUsersGetListResponse22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMigratedUsersGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
        
    }
}
