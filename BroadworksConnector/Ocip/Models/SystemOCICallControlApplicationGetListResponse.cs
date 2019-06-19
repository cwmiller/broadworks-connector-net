using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemOCICallControlApplicationGetListRequest. The table columns are:
    /// "Application Id", "Enabled System Wide", "Description" "Notification Timeout Seconds", "Max Event Channels Per Set"
    /// and "Channel Set Grace Period Seconds".
    /// <see cref="SystemOCICallControlApplicationGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12344""}]")]
    public class SystemOCICallControlApplicationGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _appTable;

        [XmlElement(ElementName = "appTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12344")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AppTable
        {
            get => _appTable;
            set
            {
                AppTableSpecified = true;
                _appTable = value;
            }
        }

        [XmlIgnore]
        public bool AppTableSpecified { get; set; }

    }
}
