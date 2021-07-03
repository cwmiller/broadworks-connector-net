using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupMeetMeConferencingGetInstanceListRequest.
    /// Contains a table with column headings: "Service User Id", "Name", "Phone Number", "Extension", "Department", "Ports", and "Is Active".
    /// The column values for "Is Active" can either be true, or false.
    /// <see cref="GroupMeetMeConferencingGetInstanceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:179""}]")]
    public class GroupMeetMeConferencingGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _conferenceBridgeTable;

        [XmlElement(ElementName = "conferenceBridgeTable", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:179")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ConferenceBridgeTable
        {
            get => _conferenceBridgeTable;
            set
            {
                ConferenceBridgeTableSpecified = true;
                _conferenceBridgeTable = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceBridgeTableSpecified { get; set; }

    }
}
