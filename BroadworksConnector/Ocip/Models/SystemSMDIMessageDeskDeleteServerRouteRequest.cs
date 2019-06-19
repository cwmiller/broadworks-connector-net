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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ee7bb69368e23a56a82c5d9cf07b5433:104""}]")]
    public class SystemSMDIMessageDeskDeleteServerRouteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _routeDestination;

        [XmlElement(ElementName = "routeDestination", IsNullable = false, Namespace = "")]
        [Group(@"ee7bb69368e23a56a82c5d9cf07b5433:104")]
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
        public bool RouteDestinationSpecified { get; set; }

    }
}
