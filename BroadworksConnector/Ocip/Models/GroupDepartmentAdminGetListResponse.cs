using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDepartmentAdminGetListRequest.
    /// Contains a 5 column table with column headings "Administrator ID",
    /// "Last Name", "First Name", "Department", "Language".
    /// <see cref="GroupDepartmentAdminGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:3529""}]")]
    public class GroupDepartmentAdminGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _departmentAdminTable;

        [XmlElement(ElementName = "departmentAdminTable", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:3529")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DepartmentAdminTable
        {
            get => _departmentAdminTable;
            set
            {
                DepartmentAdminTableSpecified = true;
                _departmentAdminTable = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentAdminTableSpecified { get; set; }

    }
}
