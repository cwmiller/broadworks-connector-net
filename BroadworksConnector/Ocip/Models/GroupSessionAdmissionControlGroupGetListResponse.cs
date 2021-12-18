using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupSessionAdmissionControlGroupGetListRequest.
    /// Contains a table of session admission control group configured in the group.
    /// The column headings are: "Name", "Is Default", "Maximum Sessions", "Maximum Originating Sessions", "Maximum Terminating Sessions".
    /// <see cref="GroupSessionAdmissionControlGroupGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:8152""}]")]
    public class GroupSessionAdmissionControlGroupGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _sessionAdmissionControlGroupTable;

        [XmlElement(ElementName = "sessionAdmissionControlGroupTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8152")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SessionAdmissionControlGroupTable
        {
            get => _sessionAdmissionControlGroupTable;
            set
            {
                SessionAdmissionControlGroupTableSpecified = true;
                _sessionAdmissionControlGroupTable = value;
            }
        }

        [XmlIgnore]
        protected bool SessionAdmissionControlGroupTableSpecified { get; set; }

    }
}
