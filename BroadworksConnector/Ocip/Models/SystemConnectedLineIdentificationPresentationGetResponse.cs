using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemConnectedLineIdentificationPresentationGetRequest.
    /// <see cref="SystemConnectedLineIdentificationPresentationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2256aa4d4c7d3679ce18e4f471895147:56""}]")]
    public class SystemConnectedLineIdentificationPresentationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enforceUserServiceAssignment;

        [XmlElement(ElementName = "enforceUserServiceAssignment", IsNullable = false, Namespace = "")]
        [Group(@"2256aa4d4c7d3679ce18e4f471895147:56")]
        public bool EnforceUserServiceAssignment
        {
            get => _enforceUserServiceAssignment;
            set
            {
                EnforceUserServiceAssignmentSpecified = true;
                _enforceUserServiceAssignment = value;
            }
        }

        [XmlIgnore]
        protected bool EnforceUserServiceAssignmentSpecified { get; set; }

    }
}
