using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderXsiPolicyProfileGetAssignedListRequest.
    /// Contains a table of all Xsi Policy Profile assigned to.
    /// The column headings are: "Name", "Level", "Description" and "Default".
    /// <see cref="ServiceProviderXsiPolicyProfileGetAssignedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:7158""}]")]
    public class ServiceProviderXsiPolicyProfileGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _assignedTable;

        [XmlElement(ElementName = "assignedTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:7158")]
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
