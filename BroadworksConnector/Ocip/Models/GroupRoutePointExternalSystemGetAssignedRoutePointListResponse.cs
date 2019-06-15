using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupRoutePointExternalSystemGetAssignedRoutePointListRequest.
    /// Contains a table with column headings:
    /// "Service User Id", "Name", "Video", "Phone Number", "Extension", "Department".
    /// The column values for "Video" can either be "true", or "false".
        /// <see cref="GroupRoutePointExternalSystemGetAssignedRoutePointListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupRoutePointExternalSystemGetAssignedRoutePointListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _routePointTable;

        [XmlElement(ElementName = "routePointTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable RoutePointTable {
            get => _routePointTable;
            set {
                RoutePointTableSpecified = true;
                _routePointTable = value;
            }
        }

        [XmlIgnore]
        public bool RoutePointTableSpecified { get; set; }
        
    }
}
