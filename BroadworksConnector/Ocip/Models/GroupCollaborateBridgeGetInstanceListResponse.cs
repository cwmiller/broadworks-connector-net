using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCollaborateBridgeGetInstanceListRequest.
    /// Contains a table with column headings: "Service User Id", "Name", "Phone Number", "Extension", "Department", "Participants", and "Is Default".
    /// The column values for "Is default" can either be true, or false.
    /// <see cref="GroupCollaborateBridgeGetInstanceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""bc805893b9cc7e3e01eec64e9ad62768:321""}]")]
    public class GroupCollaborateBridgeGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _collaborateBridgeTable;

        [XmlElement(ElementName = "collaborateBridgeTable", IsNullable = false, Namespace = "")]
        [Group(@"bc805893b9cc7e3e01eec64e9ad62768:321")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CollaborateBridgeTable
        {
            get => _collaborateBridgeTable;
            set
            {
                CollaborateBridgeTableSpecified = true;
                _collaborateBridgeTable = value;
            }
        }

        [XmlIgnore]
        protected bool CollaborateBridgeTableSpecified { get; set; }

    }
}
