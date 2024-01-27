using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseSessionAdmissionControlGroupGetListRequest.
    /// Contains a table of session admission control group configured in the enterprise.
    /// The column headings are: "Name", "Is Default", "Maximum Sessions", "Maximum Originating Sessions", "Maximum Terminating Sessions"..
    /// <see cref="EnterpriseSessionAdmissionControlGroupGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""405ec18fe08719ecf74e749d7e18c88f:678""}]")]
    public class EnterpriseSessionAdmissionControlGroupGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _sessionAdmissionControlGroupTable;

        [XmlElement(ElementName = "sessionAdmissionControlGroupTable", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:678")]
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
