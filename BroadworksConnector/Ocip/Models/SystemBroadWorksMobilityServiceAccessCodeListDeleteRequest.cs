using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a Service Access Code list.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:1366""}]")]
    public class SystemBroadWorksMobilityServiceAccessCodeListDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1366")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

    }
}
