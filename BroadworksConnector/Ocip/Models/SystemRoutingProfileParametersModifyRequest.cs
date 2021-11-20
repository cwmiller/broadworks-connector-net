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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15557""}]")]
    public class SystemRoutingProfileParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private bool _enablePermissiveRouting;

        [XmlElement(ElementName = "enablePermissiveRouting", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15557")]
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
