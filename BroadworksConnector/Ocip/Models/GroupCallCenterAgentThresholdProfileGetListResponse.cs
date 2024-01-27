using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterAgentThresholdProfileGetListRequest.
    /// Contains a table with all the  Call Center Agent Threshold Profiles in the Group.
    /// The column headings are: "Default", "Name", "Description".
    /// <see cref="GroupCallCenterAgentThresholdProfileGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:2353""}]")]
    public class GroupCallCenterAgentThresholdProfileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _profilesTable;

        [XmlElement(ElementName = "profilesTable", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:2353")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ProfilesTable
        {
            get => _profilesTable;
            set
            {
                ProfilesTableSpecified = true;
                _profilesTable = value;
            }
        }

        [XmlIgnore]
        protected bool ProfilesTableSpecified { get; set; }

    }
}
