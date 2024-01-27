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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:3672""}]")]
    public class ServiceProviderDialPlanPolicyGetAccessCodeListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _accessCodeTable;

        [XmlElement(ElementName = "accessCodeTable", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3672")]
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
