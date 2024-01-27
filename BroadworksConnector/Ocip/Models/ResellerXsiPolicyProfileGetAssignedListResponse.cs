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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d45e381d6dbac771631649063122a42e:1000""}]")]
    public class ResellerXsiPolicyProfileGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _assignedTable;

        [XmlElement(ElementName = "assignedTable", IsNullable = false, Namespace = "")]
        [Group(@"d45e381d6dbac771631649063122a42e:1000")]
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
