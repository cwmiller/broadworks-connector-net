using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemRoutingGetRouteDeviceListRequest. The column headings are "Net Address",
    /// "Port", "Transport" and "Description".
    /// <see cref="SystemRoutingGetRouteDeviceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14262""}]")]
    public class SystemRoutingGetRouteDeviceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _routeDeviceTable;

        [XmlElement(ElementName = "routeDeviceTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14262")]
        public BroadWorksConnector.Ocip.Models.C.OCITable RouteDeviceTable
        {
            get => _routeDeviceTable;
            set
            {
                RouteDeviceTableSpecified = true;
                _routeDeviceTable = value;
            }
        }

        [XmlIgnore]
        protected bool RouteDeviceTableSpecified { get; set; }

    }
}
