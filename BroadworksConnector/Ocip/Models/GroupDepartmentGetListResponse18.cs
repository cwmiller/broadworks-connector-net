using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDepartmentGetListRequest18.
    /// Contains a table of department attributes.
    /// The column headings are: "Is Enterprise Department", "Department Name", "Full Path Name", "Calling Line Id Name", and "Calling Line Id Phone Number"
    /// <see cref="GroupDepartmentGetListRequest18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:3166""}]")]
    public class GroupDepartmentGetListResponse18 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _departmentTable;

        [XmlElement(ElementName = "departmentTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3166")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DepartmentTable
        {
            get => _departmentTable;
            set
            {
                DepartmentTableSpecified = true;
                _departmentTable = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentTableSpecified { get; set; }

    }
}
