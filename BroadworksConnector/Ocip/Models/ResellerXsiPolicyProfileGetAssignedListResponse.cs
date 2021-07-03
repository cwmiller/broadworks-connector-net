using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ResellerXsiPolicyProfileGetAssignedListRequest.
    /// Contains a table of all Xsi Policy Profile assigned to.
    /// The column headings are: "Name", "Level", "Description" and "Default".
    /// <see cref="ResellerXsiPolicyProfileGetAssignedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b009175f2a2a9d38115e319a6ad64d7f:986""}]")]
    public class ResellerXsiPolicyProfileGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _assignedTable;

        [XmlElement(ElementName = "assignedTable", IsNullable = false, Namespace = "")]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:986")]
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
