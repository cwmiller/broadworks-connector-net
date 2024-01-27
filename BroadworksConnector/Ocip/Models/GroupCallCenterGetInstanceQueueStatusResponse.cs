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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:4591""}]")]
    public class GroupCallCenterGetInstanceQueueStatusResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _numberOfCallsQueuedNow;

        [XmlElement(ElementName = "numberOfCallsQueuedNow", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4591")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _agentsCurrentlyStaffed;

        [XmlElement(ElementName = "agentsCurrentlyStaffed", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4591")]
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
