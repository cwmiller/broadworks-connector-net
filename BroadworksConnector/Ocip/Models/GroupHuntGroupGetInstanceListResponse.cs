using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupHuntGroupGetInstanceListRequest.
    /// Contains a table with column headings:
    /// "Service User Id", "Name", "Phone Number", "Extension", "Department", "Is Active", "Policy".
    /// The column values for "Is Active" can either be true, or false.
    /// NOTE: prior to release 14, the policy column did not match the HuntPolicy enumerated type.
    /// <see cref="GroupHuntGroupGetInstanceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""781bbab86d937537938d4fe917029d5c:369""}]")]
    public class GroupHuntGroupGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _huntGroupTable;

        [XmlElement(ElementName = "huntGroupTable", IsNullable = false, Namespace = "")]
        [Group(@"781bbab86d937537938d4fe917029d5c:369")]
        public BroadWorksConnector.Ocip.Models.C.OCITable HuntGroupTable
        {
            get => _huntGroupTable;
            set
            {
                HuntGroupTableSpecified = true;
                _huntGroupTable = value;
            }
        }

        [XmlIgnore]
        protected bool HuntGroupTableSpecified { get; set; }

    }
}
