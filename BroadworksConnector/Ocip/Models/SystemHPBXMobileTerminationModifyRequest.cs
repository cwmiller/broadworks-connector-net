using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the hPBX mobile termination related configuration parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:11515""}]")]
    public class SystemHPBXMobileTerminationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _routingPrefix;

        [XmlElement(ElementName = "routingPrefix", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:11515")]
        [MinLength(1)]
        [MaxLength(80)]
        public string RoutingPrefix
        {
            get => _routingPrefix;
            set
            {
                RoutingPrefixSpecified = true;
                _routingPrefix = value;
            }
        }

        [XmlIgnore]
        protected bool RoutingPrefixSpecified { get; set; }

    }
}
