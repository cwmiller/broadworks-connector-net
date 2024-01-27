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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:15757""}]")]
    public class SystemRoutingProfileParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enablePermissiveRouting;

        [XmlElement(ElementName = "enablePermissiveRouting", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:15757")]
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
