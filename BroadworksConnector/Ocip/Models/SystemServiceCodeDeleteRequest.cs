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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:16089""}]")]
    public class SystemServiceCodeDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceCode;

        [XmlElement(ElementName = "serviceCode", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16089")]
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
