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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:898""}]")]
    public class SearchCriteriaExactDeviceManagementEventStatusCompleted : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.DeviceManagementEventStatusCompleted _dmEventStatusCompleted;

        [XmlElement(ElementName = "dmEventStatusCompleted", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:898")]
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
