using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallCenterGetAvailableCallCenterListRequest.
    /// Contains a table with column heading: "Service User Id".
    /// <see cref="UserCallCenterGetAvailableCallCenterListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6971""}]")]
    public class UserCallCenterGetAvailableCallCenterListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _callCenterTable;

        [XmlElement(ElementName = "callCenterTable", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6971")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CallCenterTable
        {
            get => _callCenterTable;
            set
            {
                CallCenterTableSpecified = true;
                _callCenterTable = value;
            }
        }

        [XmlIgnore]
        protected bool CallCenterTableSpecified { get; set; }

    }
}
