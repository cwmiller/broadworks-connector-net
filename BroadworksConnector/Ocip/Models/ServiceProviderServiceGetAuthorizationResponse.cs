using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderServiceGetAuthorizationRequest.
    /// If the feature was never licensed, then "authorized" is false and the remaining elements are not returned.
    /// If the service pack is available for use, "authorized" is true.
    /// "authorizedQuantity" can be unlimited or a quantity. In the case of a service pack, "authorizedQuantity" is the service pack's quantity.
    /// "authorizable" is applicable for user services and group services; it is not returned for service packs.
    /// <see cref="ServiceProviderServiceGetAuthorizationRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:5152""}]")]
    public class ServiceProviderServiceGetAuthorizationResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _authorized;

        [XmlElement(ElementName = "authorized", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5152")]
        public bool Authorized
        {
            get => _authorized;
            set
            {
                AuthorizedSpecified = true;
                _authorized = value;
            }
        }

        [XmlIgnore]
        protected bool AuthorizedSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _authorizedQuantity;

        [XmlElement(ElementName = "authorizedQuantity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5152")]
        public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt AuthorizedQuantity
        {
            get => _authorizedQuantity;
            set
            {
                AuthorizedQuantitySpecified = true;
                _authorizedQuantity = value;
            }
        }

        [XmlIgnore]
        protected bool AuthorizedQuantitySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _usedQuantity;

        [XmlElement(ElementName = "usedQuantity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5152")]
        public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt UsedQuantity
        {
            get => _usedQuantity;
            set
            {
                UsedQuantitySpecified = true;
                _usedQuantity = value;
            }
        }

        [XmlIgnore]
        protected bool UsedQuantitySpecified { get; set; }

        private bool _authorizable;

        [XmlElement(ElementName = "authorizable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5152")]
        public bool Authorizable
        {
            get => _authorizable;
            set
            {
                AuthorizableSpecified = true;
                _authorizable = value;
            }
        }

        [XmlIgnore]
        protected bool AuthorizableSpecified { get; set; }

    }
}
