using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular fully specified Device Management completed event status.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:864""}]")]
    public class SearchCriteriaExactDeviceManagementEventStatusCompleted : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private BroadWorksConnector.Ocip.Models.DeviceManagementEventStatusCompleted _dmEventStatusCompleted;

        [XmlElement(ElementName = "dmEventStatusCompleted", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:864")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementEventStatusCompleted DmEventStatusCompleted
        {
            get => _dmEventStatusCompleted;
            set
            {
                DmEventStatusCompletedSpecified = true;
                _dmEventStatusCompleted = value;
            }
        }

        [XmlIgnore]
        protected bool DmEventStatusCompletedSpecified { get; set; }

    }
}
