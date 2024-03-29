using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete a service code for the purpose of providing free format routable strings for dialing
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16305""}]")]
    public class SystemServiceCodeDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceCode;

        [XmlElement(ElementName = "serviceCode", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:16305")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceCode
        {
            get => _serviceCode;
            set
            {
                ServiceCodeSpecified = true;
                _serviceCode = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceCodeSpecified { get; set; }

    }
}
