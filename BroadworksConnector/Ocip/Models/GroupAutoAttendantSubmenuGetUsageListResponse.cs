using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupAutoAttendantSubmenuGetUsageListRequest.
    /// Contains a table with column headings:
    /// "Type" and "Submenu ID".
    /// 
    /// The "Type" Column will contain one of the following: Business Hours Menu,
    /// After Hours Menu, Holiday Menu or Submenu.
    /// 
    /// The "Submenu ID" Column will be left blank when the "Type" Column contains one
    /// of the base menu types (Business Hours Menu, After Hours Menu or Holiday Menu),
    /// and will contain the Submenu ID when the "Type" Column contains type Submenu.
    /// <see cref="GroupAutoAttendantSubmenuGetUsageListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ec63a55bc41262b2dd33a1f4e8e84674:603""}]")]
    public class GroupAutoAttendantSubmenuGetUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _submenuTable;

        [XmlElement(ElementName = "submenuTable", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:603")]
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
