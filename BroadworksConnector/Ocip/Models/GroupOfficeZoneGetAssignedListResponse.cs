using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupOfficeZoneGetAssignedListRequest.
    /// Contains a table of all Office Zones assigned to the
    /// group. The column headings are: "Name", "Description" and "Default".
    /// <see cref="GroupOfficeZoneGetAssignedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:6450""}]")]
    public class GroupOfficeZoneGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _officeZoneTable;

        [XmlElement(ElementName = "officeZoneTable", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:6450")]
        public BroadWorksConnector.Ocip.Models.C.OCITable OfficeZoneTable
        {
            get => _officeZoneTable;
            set
            {
                OfficeZoneTableSpecified = true;
                _officeZoneTable = value;
            }
        }

        [XmlIgnore]
        protected bool OfficeZoneTableSpecified { get; set; }

    }
}
