using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a GETS Resource Priority.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:11195""}]")]
    public class SystemGETSResourcePriorityDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _priorityValue;

        [XmlElement(ElementName = "priorityValue", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11195")]
        [MinLength(3)]
        [MaxLength(80)]
        public string PriorityValue
        {
            get => _priorityValue;
            set
            {
                PriorityValueSpecified = true;
                _priorityValue = value;
            }
        }

        [XmlIgnore]
        protected bool PriorityValueSpecified { get; set; }

    }
}
