using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDialPlanPolicyGetAccessCodeListRequest
    /// Contains a table with column headings: "Access Code",
    /// "Enable Secondary Dial Tone", "Description"
    /// <see cref="GroupDialPlanPolicyGetAccessCodeListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:3876""}]")]
    public class GroupDialPlanPolicyGetAccessCodeListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _accessCodeTable;

        [XmlElement(ElementName = "accessCodeTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3876")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AccessCodeTable
        {
            get => _accessCodeTable;
            set
            {
                AccessCodeTableSpecified = true;
                _accessCodeTable = value;
            }
        }

        [XmlIgnore]
        public bool AccessCodeTableSpecified { get; set; }

    }
}
