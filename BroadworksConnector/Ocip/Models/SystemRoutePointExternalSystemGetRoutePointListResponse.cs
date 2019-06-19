using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemRoutePointExternalSystemGetRoutePointListRequest.
    /// <see cref="SystemRoutePointExternalSystemGetRoutePointListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14075""}]")]
    public class SystemRoutePointExternalSystemGetRoutePointListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _serviceUserId = new List<string>();

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14075")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }

    }
}
