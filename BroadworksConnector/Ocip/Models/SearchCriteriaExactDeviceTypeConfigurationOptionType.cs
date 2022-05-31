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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:939""}]")]
    public class SearchCriteriaExactDeviceTypeConfigurationOptionType : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.DeviceTypeConfigurationOptionType _deviceConfigOptions;

        [XmlElement(ElementName = "deviceConfigOptions", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:939")]
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
