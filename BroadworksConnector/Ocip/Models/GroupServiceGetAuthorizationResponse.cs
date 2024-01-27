using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupServiceGetAuthorizationRequest.
    /// If the feature is not authorized, then "authorized" is false and the remaining elements are not returned.
    /// If the service pack is not available for use or is not authorized, then "authorized" is false and the remaining elements are not returned.
    /// "authorizedQuantity" can be unlimited or a quantity. In the case of a service pack, "authorizedQuantity" is the service pack's quantity.
    /// "authorizable" is applicable for user services and group services; it is not returned for service packs.
    /// <see cref="GroupServiceGetAuthorizationRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:7546""}]")]
    public class GroupServiceGetAuthorizationResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _authorized;

        [XmlElement(ElementName = "authorized", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:7546")]
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

        protected BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _authorizedQuantity;

        [XmlElement(ElementName = "authorizedQuantity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:7546")]
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

        protected BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _usedQuantity;

        [XmlElement(ElementName = "usedQuantity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:7546")]
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

        protected bool _authorizable;

        [XmlElement(ElementName = "authorizable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:7546")]
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
