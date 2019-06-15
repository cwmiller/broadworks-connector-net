using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest. The Unreachable From
    /// Primary User table column
    /// headings are: "User ID", "Lineport".
    /// 
    /// Replaced by: SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22 in AS data mode
        /// <see cref="SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest"/>
        /// <see cref="SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
        
    }
}
