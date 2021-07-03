using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterGetInstanceListRequest.
    /// Contains a table with column headings:
    /// "Service User Id", "Name", "Video", "Phone Number", "Extension", "Department", "Is Active", "Policy", "Type".
    /// The column values for "Video" and "Is Active" can either be true, or false.
    /// The column values for "Type" can be "Basic", "Standard" or "Premium" in AS data mode and "Basic" in XS data mode.
    /// NOTE: prior to release 14, the policy column did not match the HuntPolicy enumerated type.
    /// <see cref="GroupCallCenterGetInstanceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:4503""}]")]
    public class GroupCallCenterGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _callCenterTable;

        [XmlElement(ElementName = "callCenterTable", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4503")]
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
