using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular device level.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:853""}]")]
    public class SearchCriteriaExactDeviceLevel : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.AccessDeviceLevel _deviceLevel;

        [XmlElement(ElementName = "deviceLevel", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:853")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceLevel DeviceLevel
        {
            get => _deviceLevel;
            set
            {
                DeviceLevelSpecified = true;
                _deviceLevel = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceLevelSpecified { get; set; }

    }
}
