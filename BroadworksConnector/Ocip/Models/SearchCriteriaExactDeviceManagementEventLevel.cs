using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular fully specified DeviceManagement event level.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:883""}]")]
    public class SearchCriteriaExactDeviceManagementEventLevel : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.DeviceManagementEventLevel _dmEventLevel;

        [XmlElement(ElementName = "dmEventLevel", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:883")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementEventLevel DmEventLevel
        {
            get => _dmEventLevel;
            set
            {
                DmEventLevelSpecified = true;
                _dmEventLevel = value;
            }
        }

        [XmlIgnore]
        protected bool DmEventLevelSpecified { get; set; }

    }
}
