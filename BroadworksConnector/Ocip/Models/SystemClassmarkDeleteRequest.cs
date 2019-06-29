using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a Class Mark from system. It cannot be deleted if it is in use by any users.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0d0e878cbc947aebb19ad489b2ffef11:65""}]")]
    public class SystemClassmarkDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _classmark;

        [XmlElement(ElementName = "classmark", IsNullable = false, Namespace = "")]
        [Group(@"0d0e878cbc947aebb19ad489b2ffef11:65")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Classmark
        {
            get => _classmark;
            set
            {
                ClassmarkSpecified = true;
                _classmark = value;
            }
        }

        [XmlIgnore]
        protected bool ClassmarkSpecified { get; set; }

    }
}
