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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:9212""}]")]
    public class SystemDialPlanPolicyGetAccessCodeListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _accessCodeTable;

        [XmlElement(ElementName = "accessCodeTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:9212")]
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
