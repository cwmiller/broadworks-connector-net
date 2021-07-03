using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Removes a BroadWorks Mobility IMRN number from the system.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:711""}]")]
    public class SystemBroadWorksMobilityDeleteIMRNListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private List<string> _imrnNumber = new List<string>();

        [XmlElement(ElementName = "imrnNumber", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:711")]
        [MinLength(1)]
        [MaxLength(23)]
        public List<string> ImrnNumber
        {
            get => _imrnNumber;
            set
            {
                ImrnNumberSpecified = true;
                _imrnNumber = value;
            }
        }

        [XmlIgnore]
        protected bool ImrnNumberSpecified { get; set; }

    }
}
