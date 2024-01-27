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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7965""}]")]
    public class SystemDeviceManagementGetEventStatusSummaryCountResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _statusCountTable;

        [XmlElement(ElementName = "statusCountTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7965")]
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
