using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete a SMDI Server route from the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""aa3a240fa755015613cfb9259eccafef:104""}]")]
    public class SystemSMDIMessageDeskDeleteServerRouteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _routeDestination;

        [XmlElement(ElementName = "routeDestination", IsNullable = false, Namespace = "")]
        [Group(@"aa3a240fa755015613cfb9259eccafef:104")]
        [MinLength(1)]
        [MaxLength(10)]
        public string RouteDestination
        {
            get => _routeDestination;
            set
            {
                RouteDestinationSpecified = true;
                _routeDestination = value;
            }
        }

        [XmlIgnore]
        protected bool RouteDestinationSpecified { get; set; }

    }
}
