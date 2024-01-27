using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Routing Profile system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:15773""}]")]
    public class SystemRoutingProfileParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _enablePermissiveRouting;

        [XmlElement(ElementName = "enablePermissiveRouting", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:15773")]
        public bool EnablePermissiveRouting
        {
            get => _enablePermissiveRouting;
            set
            {
                EnablePermissiveRoutingSpecified = true;
                _enablePermissiveRouting = value;
            }
        }

        [XmlIgnore]
        protected bool EnablePermissiveRoutingSpecified { get; set; }

    }
}
