using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular fully specified DeviceTypeConfigurationOptionType.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:973""}]")]
    public class SearchCriteriaExactDeviceTypeConfigurationOptionType : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.DeviceTypeConfigurationOptionType _deviceConfigOptions;

        [XmlElement(ElementName = "deviceConfigOptions", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:973")]
        public BroadWorksConnector.Ocip.Models.DeviceTypeConfigurationOptionType DeviceConfigOptions
        {
            get => _deviceConfigOptions;
            set
            {
                DeviceConfigOptionsSpecified = true;
                _deviceConfigOptions = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceConfigOptionsSpecified { get; set; }

    }
}
