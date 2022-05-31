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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:834""}]")]
    public class SearchCriteriaExactDeviceManagementEventAction : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.DeviceManagementEventAction _dmEventAction;

        [XmlElement(ElementName = "dmEventAction", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:834")]
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
