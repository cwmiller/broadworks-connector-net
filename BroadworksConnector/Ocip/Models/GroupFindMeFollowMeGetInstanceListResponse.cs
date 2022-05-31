using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupFindMeFollowMeGetInstanceListRequest.
    /// Contains a table with column headings:
    /// "Service User Id", "Name", "Phone Number", "Extension", "Department", "Is Active".
    /// The column value for "Is Active" can either be true, or false.
    /// <see cref="GroupFindMeFollowMeGetInstanceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""79f226053ee345f2ff4c37c37c8e9114:362""}]")]
    public class GroupFindMeFollowMeGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _findMeFollowMeTable;

        [XmlElement(ElementName = "findMeFollowMeTable", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:362")]
        public BroadWorksConnector.Ocip.Models.C.OCITable FindMeFollowMeTable
        {
            get => _findMeFollowMeTable;
            set
            {
                FindMeFollowMeTableSpecified = true;
                _findMeFollowMeTable = value;
            }
        }

        [XmlIgnore]
        protected bool FindMeFollowMeTableSpecified { get; set; }

    }
}
