using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a Class Mark in system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0d0e878cbc947aebb19ad489b2ffef11:154""}]")]
    public class SystemClassmarkModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _classmark;

        [XmlElement(ElementName = "classmark", IsNullable = false, Namespace = "")]
        [Group(@"0d0e878cbc947aebb19ad489b2ffef11:154")]
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

        protected string _value;

        [XmlElement(ElementName = "value", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0d0e878cbc947aebb19ad489b2ffef11:154")]
        [MinLength(1)]
        [MaxLength(32)]
        public string Value
        {
            get => _value;
            set
            {
                ValueSpecified = true;
                _value = value;
            }
        }

        [XmlIgnore]
        protected bool ValueSpecified { get; set; }

        protected string _webDisplayKey;

        [XmlElement(ElementName = "webDisplayKey", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"0d0e878cbc947aebb19ad489b2ffef11:154")]
        [MinLength(1)]
        [MaxLength(40)]
        public string WebDisplayKey
        {
            get => _webDisplayKey;
            set
            {
                WebDisplayKeySpecified = true;
                _webDisplayKey = value;
            }
        }

        [XmlIgnore]
        protected bool WebDisplayKeySpecified { get; set; }

    }
}
