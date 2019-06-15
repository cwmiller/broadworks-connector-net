using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderServicePackMigrationTaskGetAvailableGroupListRequest.
    /// The groupTable column headings are: "Group Id", "Group Name", "User Count".
        /// <see cref="ServiceProviderServicePackMigrationTaskGetAvailableGroupListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderServicePackMigrationTaskGetAvailableGroupListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _groupTable;

        [XmlElement(ElementName = "groupTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupTable {
            get => _groupTable;
            set {
                GroupTableSpecified = true;
                _groupTable = value;
            }
        }

        [XmlIgnore]
        public bool GroupTableSpecified { get; set; }
        
    }
}
