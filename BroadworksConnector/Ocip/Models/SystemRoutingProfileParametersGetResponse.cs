using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemRoutingProfileParametersGetRequest.
    /// Contains a list of Routing Profile parameters.
    /// <see cref="SystemRoutingProfileParametersGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15541""}]")]
    public class SystemRoutingProfileParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enablePermissiveRouting;

        [XmlElement(ElementName = "enablePermissiveRouting", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15541")]
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
