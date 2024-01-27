using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupConsolidatedDnAssignListRequest.
    /// <see cref="GroupConsolidatedDnAssignListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:3082""}]")]
    public class GroupConsolidatedDnAssignListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.DNValidationStatusMessage> _dnValidationError = new List<BroadWorksConnector.Ocip.Models.DNValidationStatusMessage>();

        [XmlElement(ElementName = "dnValidationError", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:3082")]
        public List<BroadWorksConnector.Ocip.Models.DNValidationStatusMessage> DnValidationError
        {
            get => _dnValidationError;
            set
            {
                DnValidationErrorSpecified = true;
                _dnValidationError = value;
            }
        }

        [XmlIgnore]
        protected bool DnValidationErrorSpecified { get; set; }

    }
}
