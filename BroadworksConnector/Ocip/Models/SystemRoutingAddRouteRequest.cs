using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a route to the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15225""}]")]
    public class SystemRoutingAddRouteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _routeName;

        [XmlElement(ElementName = "routeName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15225")]
        [MinLength(1)]
        [MaxLength(32)]
        public string RouteName
        {
            get => _routeName;
            set
            {
                RouteNameSpecified = true;
                _routeName = value;
            }
        }

        [XmlIgnore]
        protected bool RouteNameSpecified { get; set; }

    }
}
