using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests to modify a service pack for a service provider.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:6649""}]")]
    public class ServiceProviderServicePackModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6649")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _servicePackName;

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6649")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServicePackName
        {
            get => _servicePackName;
            set
            {
                ServicePackNameSpecified = true;
                _servicePackName = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackNameSpecified { get; set; }

        protected string _newServicePackName;

        [XmlElement(ElementName = "newServicePackName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6649")]
        [MinLength(1)]
        [MaxLength(80)]
        public string NewServicePackName
        {
            get => _newServicePackName;
            set
            {
                NewServicePackNameSpecified = true;
                _newServicePackName = value;
            }
        }

        [XmlIgnore]
        protected bool NewServicePackNameSpecified { get; set; }

        protected string _servicePackDescription;

        [XmlElement(ElementName = "servicePackDescription", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6649")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ServicePackDescription
        {
            get => _servicePackDescription;
            set
            {
                ServicePackDescriptionSpecified = true;
                _servicePackDescription = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackDescriptionSpecified { get; set; }

        protected bool _isAvailableForUse;

        [XmlElement(ElementName = "isAvailableForUse", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6649")]
        public bool IsAvailableForUse
        {
            get => _isAvailableForUse;
            set
            {
                IsAvailableForUseSpecified = true;
                _isAvailableForUse = value;
            }
        }

        [XmlIgnore]
        protected bool IsAvailableForUseSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _servicePackQuantity;

        [XmlElement(ElementName = "servicePackQuantity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6649")]
        public BroadWorksConnector.Ocip.Models.UnboundedPositiveInt ServicePackQuantity
        {
            get => _servicePackQuantity;
            set
            {
                ServicePackQuantitySpecified = true;
                _servicePackQuantity = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackQuantitySpecified { get; set; }

    }
}
