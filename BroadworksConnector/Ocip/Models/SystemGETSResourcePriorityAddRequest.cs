using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a GETS Resource Priority.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:11177""}]")]
    public class SystemGETSResourcePriorityAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _priorityValue;

        [XmlElement(ElementName = "priorityValue", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11177")]
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

        protected int _priorityLevel;

        [XmlElement(ElementName = "priorityLevel", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11177")]
        [MinInclusive(1)]
        [MaxInclusive(5)]
        public int PriorityLevel
        {
            get => _priorityLevel;
            set
            {
                PriorityLevelSpecified = true;
                _priorityLevel = value;
            }
        }

        [XmlIgnore]
        protected bool PriorityLevelSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GETSPriorityClass _priorityClass;

        [XmlElement(ElementName = "priorityClass", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11177")]
        public BroadWorksConnector.Ocip.Models.GETSPriorityClass PriorityClass
        {
            get => _priorityClass;
            set
            {
                PriorityClassSpecified = true;
                _priorityClass = value;
            }
        }

        [XmlIgnore]
        protected bool PriorityClassSpecified { get; set; }

    }
}
