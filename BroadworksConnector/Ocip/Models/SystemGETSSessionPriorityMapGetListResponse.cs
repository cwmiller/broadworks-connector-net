using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGETSSessionPriorityMapGetListRequest.
    /// The table columns are: "Priority Level" and "Session Priority Value".
    /// <see cref="SystemGETSSessionPriorityMapGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:11179""}]")]
    public class SystemGETSSessionPriorityMapGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _sessionPriorityTable;

        [XmlElement(ElementName = "sessionPriorityTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11179")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SessionPriorityTable
        {
            get => _sessionPriorityTable;
            set
            {
                SessionPriorityTableSpecified = true;
                _sessionPriorityTable = value;
            }
        }

        [XmlIgnore]
        protected bool SessionPriorityTableSpecified { get; set; }

    }
}
