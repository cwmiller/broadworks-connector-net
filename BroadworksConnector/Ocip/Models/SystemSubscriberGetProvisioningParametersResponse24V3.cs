using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSubscriberGetProvisioningParametersRequest24V3.
    /// <see cref="SystemSubscriberGetProvisioningParametersRequest24V3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18586""}]")]
    public class SystemSubscriberGetProvisioningParametersResponse24V3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _configurableCLIDNormalization;

        [XmlElement(ElementName = "configurableCLIDNormalization", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18586")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18586")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:18586")]
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

        protected bool _blockUnauthorizationWhenVSubInstanceExists;

        [XmlElement(ElementName = "blockUnauthorizationWhenVSubInstanceExists", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18586")]
        public bool BlockUnauthorizationWhenVSubInstanceExists
        {
            get => _blockUnauthorizationWhenVSubInstanceExists;
            set
            {
                BlockUnauthorizationWhenVSubInstanceExistsSpecified = true;
                _blockUnauthorizationWhenVSubInstanceExists = value;
            }
        }

        [XmlIgnore]
        protected bool BlockUnauthorizationWhenVSubInstanceExistsSpecified { get; set; }

    }
}
