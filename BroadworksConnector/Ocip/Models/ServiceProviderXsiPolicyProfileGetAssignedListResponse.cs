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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:7200""}]")]
    public class ServiceProviderXsiPolicyProfileGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _assignedTable;

        [XmlElement(ElementName = "assignedTable", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:7200")]
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
