using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupRoutePointGetInstanceListRequest.
    /// Contains a table with column headings:
    /// "Service User Id", "Name", "Video", "Phone Number", "Extension", "Department", "Is Active".
    /// The column values for "Video" and "Is Active" can either be true, or false.
    /// <see cref="GroupRoutePointGetInstanceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e474d11df9a1d1d1041e589793e40de8:586""}]")]
    public class GroupRoutePointGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _routePointTable;

        [XmlElement(ElementName = "routePointTable", IsNullable = false, Namespace = "")]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:586")]
        public BroadWorksConnector.Ocip.Models.C.OCITable RoutePointTable
        {
            get => _routePointTable;
            set
            {
                RoutePointTableSpecified = true;
                _routePointTable = value;
            }
        }

        [XmlIgnore]
        protected bool RoutePointTableSpecified { get; set; }

    }
}
