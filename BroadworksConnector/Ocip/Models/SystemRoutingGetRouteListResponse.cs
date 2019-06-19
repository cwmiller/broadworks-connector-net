using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemRoutingGetRouteListRequest.
    /// <see cref="SystemRoutingGetRouteListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14291""}]")]
    public class SystemRoutingGetRouteListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _routeName = new List<string>();

        [XmlElement(ElementName = "routeName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14291")]
        [MinLength(1)]
        [MaxLength(32)]
        public List<string> RouteName
        {
            get => _routeName;
            set
            {
                RouteNameSpecified = true;
                _routeName = value;
            }
        }

        [XmlIgnore]
        public bool RouteNameSpecified { get; set; }

    }
}
