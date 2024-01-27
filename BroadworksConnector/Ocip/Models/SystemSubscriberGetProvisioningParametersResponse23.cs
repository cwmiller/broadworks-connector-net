using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSubscriberGetProvisioningParametersRequest23.
    /// 
    /// Replaced by: SystemSubscriberGetProvisioningParametersResponse24V2.
    /// <see cref="SystemSubscriberGetProvisioningParametersRequest23"/>
    /// <see cref="SystemSubscriberGetProvisioningParametersResponse24V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:35974""}]")]
    public class SystemSubscriberGetProvisioningParametersResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _configurableCLIDNormalization;

        [XmlElement(ElementName = "configurableCLIDNormalization", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:35974")]
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

        protected BroadWorksConnector.Ocip.Models.AuthorizationLevelToProvisionAlternateUserID _minAuthLevelToProvisionAltUserID;

        [XmlElement(ElementName = "minAuthLevelToProvisionAltUserID", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:35974")]
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
