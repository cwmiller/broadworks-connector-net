using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of Application Controllers assigned to the Route Point External Systems specified.
    /// The response is either SystemRoutePointExternalSystemApplicationControllerGetResponse or ErrorResponse.
    /// <see cref="SystemRoutePointExternalSystemApplicationControllerGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15076""}]")]
    public class SystemRoutePointExternalSystemApplicationControllerGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemRoutePointExternalSystemApplicationControllerGetResponse>
    {

        protected string _externalSystem;

        [XmlElement(ElementName = "externalSystem", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15076")]
        [MinLength(1)]
        [MaxLength(40)]
        public string ExternalSystem
        {
            get => _externalSystem;
            set
            {
                ExternalSystemSpecified = true;
                _externalSystem = value;
            }
        }

        [XmlIgnore]
        protected bool ExternalSystemSpecified { get; set; }

    }
}
