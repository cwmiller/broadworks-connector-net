using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceManagementGetEventStatusSummaryCountRequest.
    /// The column headings are "Action, "Pending", "Queued Internally", and "Completed"
    /// <see cref="SystemDeviceManagementGetEventStatusSummaryCountRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7144""}]")]
    public class SystemDeviceManagementGetEventStatusSummaryCountResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _statusCountTable;

        [XmlElement(ElementName = "statusCountTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7144")]
        public BroadWorksConnector.Ocip.Models.C.OCITable StatusCountTable
        {
            get => _statusCountTable;
            set
            {
                StatusCountTableSpecified = true;
                _statusCountTable = value;
            }
        }

        [XmlIgnore]
        protected bool StatusCountTableSpecified { get; set; }

    }
}
