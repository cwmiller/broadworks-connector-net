using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderDialPlanPolicyGetAccessCodeListRequest.
    /// Contains a table with column headings: "Access Code",
    /// "Enable Secondary Dial Tone", "Description".
    /// <see cref="ServiceProviderDialPlanPolicyGetAccessCodeListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:2947""}]")]
    public class ServiceProviderDialPlanPolicyGetAccessCodeListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _accessCodeTable;

        [XmlElement(ElementName = "accessCodeTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2947")]
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
