using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a GETS reserved Number.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:11018""}]")]
    public class SystemGETSNumberAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _number;

        [XmlElement(ElementName = "number", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11018")]
        [MinLength(4)]
        [MaxLength(10)]
        public string Number
        {
            get => _number;
            set
            {
                NumberSpecified = true;
                _number = value;
            }
        }

        [XmlIgnore]
        protected bool NumberSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GETSNumberType _type;

        [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11018")]
        public BroadWorksConnector.Ocip.Models.GETSNumberType Type
        {
            get => _type;
            set
            {
                TypeSpecified = true;
                _type = value;
            }
        }

        [XmlIgnore]
        protected bool TypeSpecified { get; set; }

        protected string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:11018")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

    }
}
