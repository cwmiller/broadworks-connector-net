using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupAutoAttendantSubmenuGetListRequest.
    /// Contains a table with column headings:
    /// "Submenu Id" "Is Used".
    /// The column values for "Is Used" can either be true, or false.
    /// <see cref="GroupAutoAttendantSubmenuGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ec63a55bc41262b2dd33a1f4e8e84674:523""}]")]
    public class GroupAutoAttendantSubmenuGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _submenuTable;

        [XmlElement(ElementName = "submenuTable", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:523")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SubmenuTable
        {
            get => _submenuTable;
            set
            {
                SubmenuTableSpecified = true;
                _submenuTable = value;
            }
        }

        [XmlIgnore]
        protected bool SubmenuTableSpecified { get; set; }

    }
}
