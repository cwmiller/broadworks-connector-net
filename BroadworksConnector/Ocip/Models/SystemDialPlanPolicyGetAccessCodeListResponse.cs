using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDialPlanPolicyGetAccessCodeListRequest.
    /// Contains a table with column headings: "Access Code", "Enable Secondary Dial Tone", "Description"
    /// <see cref="SystemDialPlanPolicyGetAccessCodeListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9088""}]")]
    public class SystemDialPlanPolicyGetAccessCodeListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _accessCodeTable;

        [XmlElement(ElementName = "accessCodeTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9088")]
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
        protected bool AccessCodeTableSpecified { get; set; }

    }
}
