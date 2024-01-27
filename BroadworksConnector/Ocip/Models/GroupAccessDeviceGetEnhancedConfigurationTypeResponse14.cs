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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:846""}]")]
    public class GroupAccessDeviceGetEnhancedConfigurationTypeResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _supportsEnhancedConfiguration;

        [XmlElement(ElementName = "supportsEnhancedConfiguration", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:846")]
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

        protected bool _supportsReset;

        [XmlElement(ElementName = "supportsReset", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:846")]
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

        protected BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 _configurationType;

        [XmlElement(ElementName = "configurationType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:846")]
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

        protected string _configurationFileName;

        [XmlElement(ElementName = "configurationFileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:846")]
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
