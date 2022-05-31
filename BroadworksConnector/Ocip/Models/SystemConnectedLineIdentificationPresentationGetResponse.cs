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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2ea11c5e213a79b17d4a363684d76c57:57""}]")]
    public class SystemConnectedLineIdentificationPresentationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enforceUserServiceAssignment;

        [XmlElement(ElementName = "enforceUserServiceAssignment", IsNullable = false, Namespace = "")]
        [Group(@"2ea11c5e213a79b17d4a363684d76c57:57")]
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
