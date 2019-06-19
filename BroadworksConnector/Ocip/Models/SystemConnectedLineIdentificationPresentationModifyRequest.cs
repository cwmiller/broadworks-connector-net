using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with the COLP Service.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2ea11c5e213a79b17d4a363684d76c57:73""}]")]
    public class SystemConnectedLineIdentificationPresentationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _enforceUserServiceAssignment;

        [XmlElement(ElementName = "enforceUserServiceAssignment", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2ea11c5e213a79b17d4a363684d76c57:73")]
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
        public bool EnforceUserServiceAssignmentSpecified { get; set; }

    }
}
