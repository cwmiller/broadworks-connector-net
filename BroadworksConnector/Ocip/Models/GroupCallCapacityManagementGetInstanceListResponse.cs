using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCapacityManagementGetInstanceListRequest.
    /// Contains a table with column headings: "Name", "Is Default", "Maximum Calls", "Maximum Incoming Calls", "Maximum Outgoing Calls".
    /// <see cref="GroupCallCapacityManagementGetInstanceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7e3b48428e45d35b1edd744adc90f9b:190""}]")]
    public class GroupCallCapacityManagementGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _callCapacityGroupTable;

        [XmlElement(ElementName = "callCapacityGroupTable", IsNullable = false, Namespace = "")]
        [Group(@"f7e3b48428e45d35b1edd744adc90f9b:190")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CallCapacityGroupTable
        {
            get => _callCapacityGroupTable;
            set
            {
                CallCapacityGroupTableSpecified = true;
                _callCapacityGroupTable = value;
            }
        }

        [XmlIgnore]
        protected bool CallCapacityGroupTableSpecified { get; set; }

    }
}
