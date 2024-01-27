using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupDnGetAssignmentListRequest.
    /// The response contains a table with columns: "Phone Numbers", "Assigned To", "Department", "Activated".
    /// The "Phone Numbers" column contains either a single DN or a range of DNs.
    /// The "Assigned To" column contains the user name or service instance name possessing the DN(s).
    /// The "Department" column contains the department of the DN, not the department of the user or service instance.
    /// The "Activated" column indicates if the DN or DN range has been activated.  Only has a value if the DN(s) is assigned to a user.
    /// 
    /// Replaced by: GroupDnGetAssignmentListResponse18
    /// <see cref="GroupDnGetAssignmentListRequest"/>
    /// <see cref="GroupDnGetAssignmentListResponse18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:9578""}]")]
    public class GroupDnGetAssignmentListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _dnTable;

        [XmlElement(ElementName = "dnTable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:9578")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DnTable
        {
            get => _dnTable;
            set
            {
                DnTableSpecified = true;
                _dnTable = value;
            }
        }

        [XmlIgnore]
        protected bool DnTableSpecified { get; set; }

    }
}
