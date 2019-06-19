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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:790""}]")]
    public class SearchCriteriaExactDeviceManagementEventLevel : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private BroadWorksConnector.Ocip.Models.DeviceManagementEventLevel _dmEventLevel;

        [XmlElement(ElementName = "dmEventLevel", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:790")]
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
        public bool DmEventLevelSpecified { get; set; }

    }
}
