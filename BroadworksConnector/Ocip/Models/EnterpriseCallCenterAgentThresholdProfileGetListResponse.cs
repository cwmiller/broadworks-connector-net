using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the EnterpriseCallCenterAgentThresholdProfileGetListRequest.
    /// Contains a table with all the  Call Center Agent Threshold Profiles in the Enterprise.
    /// The column headings are: "Default", "Name", "Description".
    /// <see cref="EnterpriseCallCenterAgentThresholdProfileGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:569""}]")]
    public class EnterpriseCallCenterAgentThresholdProfileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _profilesTable;

        [XmlElement(ElementName = "profilesTable", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:569")]
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
