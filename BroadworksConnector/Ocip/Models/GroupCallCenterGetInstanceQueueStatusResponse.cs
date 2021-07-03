using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains Call Center queue status and a table with column headings:
    /// "User Id", "First Name", "Last Name", "Phone Number", "Extension", "Department", "Email Address".
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:4595""}]")]
    public class GroupCallCenterGetInstanceQueueStatusResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _numberOfCallsQueuedNow;

        [XmlElement(ElementName = "numberOfCallsQueuedNow", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4595")]
        public int NumberOfCallsQueuedNow
        {
            get => _numberOfCallsQueuedNow;
            set
            {
                NumberOfCallsQueuedNowSpecified = true;
                _numberOfCallsQueuedNow = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfCallsQueuedNowSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _agentsCurrentlyStaffed;

        [XmlElement(ElementName = "agentsCurrentlyStaffed", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4595")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AgentsCurrentlyStaffed
        {
            get => _agentsCurrentlyStaffed;
            set
            {
                AgentsCurrentlyStaffedSpecified = true;
                _agentsCurrentlyStaffed = value;
            }
        }

        [XmlIgnore]
        protected bool AgentsCurrentlyStaffedSpecified { get; set; }

    }
}
