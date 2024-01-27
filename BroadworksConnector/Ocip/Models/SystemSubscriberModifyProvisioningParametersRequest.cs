using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system provisioning configuration for all subscribers.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18358""}]")]
    public class SystemSubscriberModifyProvisioningParametersRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _configurableCLIDNormalization;

        [XmlElement(ElementName = "configurableCLIDNormalization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18358")]
        public bool ConfigurableCLIDNormalization
        {
            get => _configurableCLIDNormalization;
            set
            {
                ConfigurableCLIDNormalizationSpecified = true;
                _configurableCLIDNormalization = value;
            }
        }

        [XmlIgnore]
        protected bool ConfigurableCLIDNormalizationSpecified { get; set; }

        protected bool _includeDefaultDomain;

        [XmlElement(ElementName = "includeDefaultDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18358")]
        public bool IncludeDefaultDomain
        {
            get => _includeDefaultDomain;
            set
            {
                IncludeDefaultDomainSpecified = true;
                _includeDefaultDomain = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeDefaultDomainSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AuthorizationLevelToProvisionAlternateUserID _minAuthLevelToProvisionAltUserID;

        [XmlElement(ElementName = "minAuthLevelToProvisionAltUserID", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18358")]
        public BroadWorksConnector.Ocip.Models.AuthorizationLevelToProvisionAlternateUserID MinAuthLevelToProvisionAltUserID
        {
            get => _minAuthLevelToProvisionAltUserID;
            set
            {
                MinAuthLevelToProvisionAltUserIDSpecified = true;
                _minAuthLevelToProvisionAltUserID = value;
            }
        }

        [XmlIgnore]
        protected bool MinAuthLevelToProvisionAltUserIDSpecified { get; set; }

    }
}
