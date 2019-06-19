using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Authorize a user service.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:1314""}]")]
    public class CombinedUserServiceAuthorization
    {

        private BroadWorksConnector.Ocip.Models.UserService _serviceName;

        [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1314")]
        public BroadWorksConnector.Ocip.Models.UserService ServiceName
        {
            get => _serviceName;
            set
            {
                ServiceNameSpecified = true;
                _serviceName = value;
            }
        }

        [XmlIgnore]
        public bool ServiceNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _authorizedQuantity;

        [XmlElement(ElementName = "authorizedQuantity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1314")]
        public BroadWorksConnector.Ocip.Models.UnboundedPositiveInt AuthorizedQuantity
        {
            get => _authorizedQuantity;
            set
            {
                AuthorizedQuantitySpecified = true;
                _authorizedQuantity = value;
            }
        }

        [XmlIgnore]
        public bool AuthorizedQuantitySpecified { get; set; }

    }
}
