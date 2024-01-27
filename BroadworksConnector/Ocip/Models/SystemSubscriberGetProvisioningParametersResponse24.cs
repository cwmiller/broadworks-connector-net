using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSubscriberGetProvisioningParametersRequest24.
    /// 
    /// Replaced by: SystemSubscriberGetProvisioningParametersResponse24V2.
    /// <see cref="SystemSubscriberGetProvisioningParametersRequest24"/>
    /// <see cref="SystemSubscriberGetProvisioningParametersResponse24V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:35992""}]")]
    public class SystemSubscriberGetProvisioningParametersResponse24 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _configurableCLIDNormalization;

        [XmlElement(ElementName = "configurableCLIDNormalization", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:35992")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:35992")]
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

    }
}
