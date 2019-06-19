using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupDialableCallerIDGetRequest.
    /// The criteria table's column headings are "Active", "Name", "Description", "Prefix Digits", "Priority".
    /// <see cref="GroupDialableCallerIDGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:3779""}]")]
    public class GroupDialableCallerIDGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useGroupCriteria;

        [XmlElement(ElementName = "useGroupCriteria", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3779")]
        public bool UseGroupCriteria
        {
            get => _useGroupCriteria;
            set
            {
                UseGroupCriteriaSpecified = true;
                _useGroupCriteria = value;
            }
        }

        [XmlIgnore]
        public bool UseGroupCriteriaSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.NsScreeningFailurePolicy _nsScreeningFailurePolicy;

        [XmlElement(ElementName = "nsScreeningFailurePolicy", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3779")]
        public BroadWorksConnector.Ocip.Models.NsScreeningFailurePolicy NsScreeningFailurePolicy
        {
            get => _nsScreeningFailurePolicy;
            set
            {
                NsScreeningFailurePolicySpecified = true;
                _nsScreeningFailurePolicy = value;
            }
        }

        [XmlIgnore]
        public bool NsScreeningFailurePolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _criteriaTable;

        [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3779")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CriteriaTable
        {
            get => _criteriaTable;
            set
            {
                CriteriaTableSpecified = true;
                _criteriaTable = value;
            }
        }

        [XmlIgnore]
        public bool CriteriaTableSpecified { get; set; }

    }
}
