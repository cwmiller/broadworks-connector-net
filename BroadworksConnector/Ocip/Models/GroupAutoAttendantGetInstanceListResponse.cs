using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupAutoAttendantGetInstanceListRequest.
    /// Contains a table with column headings:
    /// "Service User Id", "Name", "Video", "Phone Number", "Extension", "Department", "Is Active", "Type".
    /// The column values for "Video" and "Is Active" can either be true, or false.
    /// The column values for "Type" can either be Basic or Standard.
    /// 
    /// In XS Mode the value for the "Type" column will always be populated with Basic.
    /// <see cref="GroupAutoAttendantGetInstanceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ec63a55bc41262b2dd33a1f4e8e84674:260""}]")]
    public class GroupAutoAttendantGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _autoAttendantTable;

        [XmlElement(ElementName = "autoAttendantTable", IsNullable = false, Namespace = "")]
        [Group(@"ec63a55bc41262b2dd33a1f4e8e84674:260")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AutoAttendantTable
        {
            get => _autoAttendantTable;
            set
            {
                AutoAttendantTableSpecified = true;
                _autoAttendantTable = value;
            }
        }

        [XmlIgnore]
        protected bool AutoAttendantTableSpecified { get; set; }

    }
}
