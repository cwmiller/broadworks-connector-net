using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupXsiPolicyProfileGetAssignedListRequest.
    /// Contains a table of all Xsi Policy Profile assigned to.
    /// The column headings are: "Name", "Level", "Description" and "Default".
    /// <see cref="GroupXsiPolicyProfileGetAssignedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:8670""}]")]
    public class GroupXsiPolicyProfileGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _assignedTable;

        [XmlElement(ElementName = "assignedTable", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8670")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AssignedTable
        {
            get => _assignedTable;
            set
            {
                AssignedTableSpecified = true;
                _assignedTable = value;
            }
        }

        [XmlIgnore]
        protected bool AssignedTableSpecified { get; set; }

    }
}
