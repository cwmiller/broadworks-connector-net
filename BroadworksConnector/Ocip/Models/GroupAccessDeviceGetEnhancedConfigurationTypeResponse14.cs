using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccessDeviceGetEnhancedConfigurationTypeRequest14.
    /// <see cref="GroupAccessDeviceGetEnhancedConfigurationTypeRequest14"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:853""}]")]
    public class GroupAccessDeviceGetEnhancedConfigurationTypeResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _supportsEnhancedConfiguration;

        [XmlElement(ElementName = "supportsEnhancedConfiguration", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:853")]
        public bool SupportsEnhancedConfiguration
        {
            get => _supportsEnhancedConfiguration;
            set
            {
                SupportsEnhancedConfigurationSpecified = true;
                _supportsEnhancedConfiguration = value;
            }
        }

        [XmlIgnore]
        protected bool SupportsEnhancedConfigurationSpecified { get; set; }

        private bool _supportsReset;

        [XmlElement(ElementName = "supportsReset", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:853")]
        public bool SupportsReset
        {
            get => _supportsReset;
            set
            {
                SupportsResetSpecified = true;
                _supportsReset = value;
            }
        }

        [XmlIgnore]
        protected bool SupportsResetSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 _configurationType;

        [XmlElement(ElementName = "configurationType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:853")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 ConfigurationType
        {
            get => _configurationType;
            set
            {
                ConfigurationTypeSpecified = true;
                _configurationType = value;
            }
        }

        [XmlIgnore]
        protected bool ConfigurationTypeSpecified { get; set; }

        private string _configurationFileName;

        [XmlElement(ElementName = "configurationFileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:853")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ConfigurationFileName
        {
            get => _configurationFileName;
            set
            {
                ConfigurationFileNameSpecified = true;
                _configurationFileName = value;
            }
        }

        [XmlIgnore]
        protected bool ConfigurationFileNameSpecified { get; set; }

    }
}
