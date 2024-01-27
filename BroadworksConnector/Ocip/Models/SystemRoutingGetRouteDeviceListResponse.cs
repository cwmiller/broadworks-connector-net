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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:15574""}]")]
    public class SystemRoutingGetRouteDeviceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _routeDeviceTable;

        [XmlElement(ElementName = "routeDeviceTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:15574")]
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
