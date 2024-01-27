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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:3693""}]")]
    public class GroupDepartmentGetListResponse18 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _departmentTable;

        [XmlElement(ElementName = "departmentTable", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:3693")]
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
        protected bool DepartmentTableSpecified { get; set; }

    }
}
