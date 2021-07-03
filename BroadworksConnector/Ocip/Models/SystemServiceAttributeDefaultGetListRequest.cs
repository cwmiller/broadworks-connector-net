using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the default attributes for a service that are used when assigning the feature.
    /// The response is either a SystemServiceAttributeDefaultGetListResponse or an ErrorResponse.
    /// <see cref="SystemServiceAttributeDefaultGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:16023""}]")]
    public class SystemServiceAttributeDefaultGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.ServiceCategory _serviceName;

        [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16023")]
        public BroadWorksConnector.Ocip.Models.ServiceCategory ServiceName
        {
            get => _serviceName;
            set
            {
                ServiceNameSpecified = true;
                _serviceName = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceNameSpecified { get; set; }

    }
}
