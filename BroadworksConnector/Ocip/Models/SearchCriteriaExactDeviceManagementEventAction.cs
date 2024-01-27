using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular fully specified DeviceManagement event action.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:868""}]")]
    public class SearchCriteriaExactDeviceManagementEventAction : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.DeviceManagementEventAction _dmEventAction;

        [XmlElement(ElementName = "dmEventAction", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:868")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementEventAction DmEventAction
        {
            get => _dmEventAction;
            set
            {
                DmEventActionSpecified = true;
                _dmEventAction = value;
            }
        }

        [XmlIgnore]
        protected bool DmEventActionSpecified { get; set; }

    }
}
