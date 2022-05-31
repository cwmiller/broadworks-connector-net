using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupFindMeFollowMeGetAlertingGroupListRequest.
    /// Contains a table with column headings:
    /// "Name", "Priority".
    /// <see cref="GroupFindMeFollowMeGetAlertingGroupListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""79f226053ee345f2ff4c37c37c8e9114:237""}]")]
    public class GroupFindMeFollowMeGetAlertingGroupListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _alertingGroupTable;

        [XmlElement(ElementName = "alertingGroupTable", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:237")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AlertingGroupTable
        {
            get => _alertingGroupTable;
            set
            {
                AlertingGroupTableSpecified = true;
                _alertingGroupTable = value;
            }
        }

        [XmlIgnore]
        protected bool AlertingGroupTableSpecified { get; set; }

    }
}
