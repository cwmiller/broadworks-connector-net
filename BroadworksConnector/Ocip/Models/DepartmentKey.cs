using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Uniquely identifies a department system-wide.
    /// Departments are contained in either an enterprise or a group. Enterprise departments can be
    /// used by any or all groups within the enterprise. Department names are unique within a group and
    /// within an enterprise, but the same department name can exist in 2 different groups or in both
    /// a group and its parent enterprise. Therefore, to uniquely identify a department, we must know
    /// the department name and which enterprise or group contains the department.
    /// This type is extended by group and enterprise department keys.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.EnterpriseDepartmentKey))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.GroupDepartmentKey))]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2050""}]")]
    public abstract class DepartmentKey
    {

    }
}
